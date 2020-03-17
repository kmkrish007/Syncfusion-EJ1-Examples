using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.EJ.Export;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public string Import()
        {
            string HtmlString = string.Empty;
            if (HttpContext.Request.Files.AllKeys.Any())
            {
                string RTEID = HttpContext.Request.QueryString["rteid"];
                var fileName = RTEID + "_importUpload";
                var httpPostedFile = HttpContext.Request.Files[fileName];
                if (httpPostedFile != null)
                {
                    using (var mStream = new MemoryStream())
                    {
                        new WordDocument(httpPostedFile.InputStream).Save(mStream, FormatType.Html);
                        mStream.Position = 0;
                        HtmlString = new StreamReader(mStream).ReadToEnd();
                    };

                    HtmlString = ExtractBodyContent(HtmlString);

                    foreach (var item in DecodeKeys())
                    {
                        HtmlString = HtmlString.Replace(item.Key, item.Value);
                    }
                }
                else HttpContext.Response.Write("Select any file to upload.");

            }
            return HtmlString;
        }
        public IDictionary<string, string> DecodeKeys()
        {
            IDictionary<string, string> KeyValuePair = new Dictionary<string, string>()
            {
               {"\"", "'"},{"\r", " "},{"\n", "<br/> "},{"\r\n", " "},{"( )+", " "},{"&nbsp;", " "},{"&bull;", "*"},{"&lsaquo;", "<"},
               {"&rsaquo;", ">"},{"&trade;", "(tm)"},{"&copy;", "(c)"},{"&reg;", "(r)"}
            };

            return KeyValuePair;
        }

        public string ExtractBodyContent(string html)
        {
            if (html.Contains("<html") && html.Contains("<body"))
            {
                return html.Remove(0, html.IndexOf("<body>") + 6).Replace("</body></html>", "");

            }
            return html;
        }
        [HttpPost]
        [ValidateInput(false)]
        public void ExportToWord()
        {

            string RTEID = HttpContext.Request.QueryString["rteid"];
            string FileName = HttpContext.Request.Params[RTEID + "_inputFile"];
            string htmlText = HttpContext.Request.Params[RTEID + "_inputVal"];
            WordDocument document = GetDocument(htmlText);
            document.Save(FileName + ".docx", FormatType.Docx, System.Web.HttpContext.Current.Response, HttpContentDisposition.Attachment);
        }

        [HttpPost]
        [ValidateInput(false)]
        public void ExportToPDF()
        {
            string RTEID = HttpContext.Request.QueryString["rteid"];
            string FileName = HttpContext.Request.Params[RTEID + "_inputFile"];
            string htmlText = HttpContext.Request.Params[RTEID + "_inputVal"];
            WordDocument document = GetDocument(htmlText);
            DocToPDFConverter converter = new DocToPDFConverter();
            PdfDocument pdfDocument = converter.ConvertToPDF(document);
            pdfDocument.Save(FileName + ".pdf", System.Web.HttpContext.Current.Response, HttpReadType.Save);
        }


        public WordDocument GetDocument(string htmlText)
        {
            WordDocument document = null;
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.Default);
            htmlText = htmlText.Replace("\"", "'");
            var oldSrc = getArray(htmlText); // get the copy of the src attributes in img tag and store in an array   
            XmlConversion XmlText = new XmlConversion(htmlText);
            XhtmlConversion XhtmlText = new XhtmlConversion(XmlText);
            var text = XhtmlText.ToString();
            var newSrc = getArray(text); // get the modified src attributes for replacing and store in another array   
            for (int i = 0; i < oldSrc.Count(); i++) // replace the modified src attributes with original   
            {
                text = text.Replace(newSrc[i], oldSrc[i]);
            }
            writer.Write(text);
            writer.Flush();
            stream.Position = 0;
            document = new WordDocument(stream, FormatType.Html, XHTMLValidationType.None);
            return document;
        }

        public string[] getArray(string text)
        {
            List<string> image = new List<string>();
            MatchCollection imgsrc = Regex.Matches(text, "src\\s*=\\s*['\"](?<src>[^'\"]*)['\"]");
            foreach (var element in imgsrc)
            {
                image.Add(element.ToString());
            }
            return image.ToArray();
        }
    }
}