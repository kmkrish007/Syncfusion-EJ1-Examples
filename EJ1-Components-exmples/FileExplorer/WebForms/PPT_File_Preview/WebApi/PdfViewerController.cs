using Newtonsoft.Json;
using Syncfusion.EJ.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Http;
using System.Web;
using Syncfusion.Presentation;
using Syncfusion.Pdf;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.PresentationToPdfConverter;

namespace FileExp.WebApi
{
    public class PdfViewerController : ApiController
    {

        public object Load(Dictionary<string, string> jsonResult)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            //load the multiple document from client side 
            if (jsonResult.ContainsKey("newFileName"))
            {
                var name = jsonResult["newFileName"];
                string fileName = name.Split(new string[] { "://" }, StringSplitOptions.None)[0];
                if (fileName == "http" || fileName == "https")
                {
                    var WebClient = new WebClient();
                    byte[] pdfDoc = WebClient.DownloadData(name);
                    helper.Load(pdfDoc);
                }
                else
                {
                    string path = HttpContext.Current.Server.MapPath("~/FileBrowser/Document/" + name);

                    IPresentation pptxDoc = Presentation.Open(path);

                    //Creates an instance of ChartToImageConverter and assigns it to ChartToImageConverter property of Presentation
                    pptxDoc.ChartToImageConverter = new ChartToImageConverter();

                    //Converts the PowerPoint Presentation into PDF document
                    PdfDocument pdfDocument = PresentationToPdfConverter.Convert(pptxDoc);
                    MemoryStream ms = new MemoryStream();
                    pdfDocument.Save(ms);
               //     System.IO.File.WriteAllBytes(HttpContext.Current.Server.MapPath("~/FileBrowser/Document/out.pdf"), ms.ToArray());
                    //Closes the PDF document
                    pdfDocument.Close(true);

                    //Closes the Presentation
                    pptxDoc.Close();
                    helper.Load(ms);
                }

            }
            else
            {
                if (jsonResult.ContainsKey("isInitialLoading"))
                {
                    if (jsonResult.ContainsKey("file"))
                    {
                        var name = jsonResult["file"];
                        string fileName = name.Split(new string[] { "://" }, StringSplitOptions.None)[0];
                        if (fileName == "http" || fileName == "https")
                        {
                            var WebClient = new WebClient();
                            byte[] pdfDoc = WebClient.DownloadData(name);
                            helper.Load(pdfDoc);
                        }
                        else
                        {
                            helper.Load(name);
                        }
                    }
                    else
                    {
                        byte[] doc = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Data/HTTP Succinctly.pdf"));
                        //helper.Load(HttpContext.Current.Server.MapPath("~/Data/HTTP Succinctly.pdf"));
                        helper.Load(doc);

                    }
                }
            }
            return JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
        }

        //Post action for processing the PDF documents when uploading to the ejPdfviewer widget.
        public object FileUpload(Dictionary<string, string> jsonResult)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            if (jsonResult.ContainsKey("uploadedFile"))
            {
                var fileUrl = jsonResult["uploadedFile"];
                byte[] byteArray = Convert.FromBase64String(fileUrl);
                MemoryStream stream = new MemoryStream(byteArray);
                helper.Load(stream);
            }
            return JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
        }

        //Post action for downloading the PDF documents from the ejPdfviewer widget.
        public object Download(Dictionary<string, string> jsonResult)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            return helper.GetDocumentData(jsonResult);
        }

        //Post action for unloading and disposing the PDF document resources in server side from the ejPdfviewer widget.
        public void Unload()
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            helper.Unload();
        }
    }
}
