using Syncfusion.SpellChecker.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        internal static SpellCheckerBase baseDictionary, customDictionary;
        private readonly static string _customFilePath = HttpContext.Current.Server.MapPath("~/App_Data/SpellCheck/Custom.dic"); // Here we need to specify the corresponding file name
        private readonly static List<Status> errorWords = new List<Status>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (baseDictionary == null)
            {
                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/SpellCheck/Default.dic");
                // Here we need to specify the corresponding file name
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                baseDictionary = new SpellCheckerBase(stream);
            }
            CustomFileRead();
        }

        [WebMethod]
        public static object AddToDictionary(object data)
        {
            var serializer = new JavaScriptSerializer();
            var args = (Actions)serializer.Deserialize(data.ToString(), typeof(Actions));
            if (args.CustomWord != null)
            {
                AddToCustomDictionary(args.CustomWord);
            }
            return args.CustomWord;
        }

        [WebMethod]
        public static object CheckWords(object data)
        {
            var serializer = new JavaScriptSerializer();
            Actions args = (Actions)serializer.Deserialize(data.ToString(), typeof(Actions));
            if (args.RequestType == "checkWords")
            {
                baseDictionary.IgnoreAlphaNumericWords = args.Model.IgnoreAlphaNumericWords;
                baseDictionary.IgnoreEmailAddress = args.Model.IgnoreEmailAddress;
                baseDictionary.IgnoreMixedCaseWords = args.Model.IgnoreMixedCaseWords;
                baseDictionary.IgnoreUpperCaseWords = args.Model.IgnoreUpperCase;
                baseDictionary.IgnoreUrl = args.Model.IgnoreUrl;
                baseDictionary.IgnoreFileNames = args.Model.IgnoreFileNames;
                var errorWordsCollection = SplitWords(args.Text);
                return errorWordsCollection;
            }
            else if (args.RequestType == "getSuggestions")
            {
                return baseDictionary.GetSuggestions(args.ErrorWord);
            }
            return "";
        }
        private static void AddToCustomDictionary(string word)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(_customFilePath, true))
            {
                file.Write(word + Environment.NewLine);
            }
            CustomFileRead();
        }

        private static List<Status> SplitWords(string text)
        {
            var words = text.Split(null);
            foreach (var word in words)
            {
                string textWord;
                Uri uriResult;
                bool checkUrl = Uri.TryCreate(word, UriKind.Absolute, out uriResult)
                              && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if (checkUrl)
                {
                    textWord = word;
                    if (CheckWord(textWord))
                    {
                        GetStatus(textWord);
                    }
                }
                else if (Regex.IsMatch(word,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase))
                {
                    textWord = word;
                    if (CheckWord(textWord))
                    {
                        GetStatus(textWord);
                    }
                }
                else if (Regex.IsMatch(word, @"[a-zA-Z0-9_$\-\.\\]*\\[a-zA-Z0-9_$\-\.\\]+"))
                {
                    textWord = word;
                    if (CheckWord(textWord))
                    {
                        GetStatus(textWord);
                    }
                }
                else
                {
                    if (word.EndsWith(".") || word.EndsWith(","))
                    {
                        textWord = word.Remove(word.Length - 1);
                    }
                    else if (word.Contains('\t') || word.Contains('\n') || word.Contains('\r'))
                    {
                        textWord = Regex.Replace(word, @"\t|\n|\r", "");
                    }
                    else
                    {
                        textWord = word;
                    }
                    GetStatus(textWord);
                }
            }
            return errorWords;
        }
        private static void CustomFileRead()
        {
            Stream stream1 = new FileStream(_customFilePath, FileMode.Open, FileAccess.ReadWrite);
            customDictionary = new SpellCheckerBase(stream1);
        }
        private static bool CheckWord(string word)
        {
            var flag = false;
            if (baseDictionary.HasError(word))
            {
                flag = true;
                using (StreamReader sr = new StreamReader(_customFilePath))
                {
                    var contents = sr.ReadToEnd();
                    if (contents != "")
                    {
                        flag = customDictionary.HasError(word) ? true : false;
                    }
                }
            }
            return flag;
        }
        private static List<Status> GetStatus(string textWord)
        {
            var splitWords = Regex.Replace(textWord, @"[^0-9a-zA-Z\'_]", " ").Split(null);
            foreach (var inputWord in splitWords)
            {
                if (CheckWord(inputWord))
                {
                    errorWords.Add(new Status
                    {
                        ErrorWord = inputWord
                    });
                }
            }
            return errorWords;
        }
    }

    public class Status
    {
        public string ErrorWord { get; set; }
    }
    public class Actions
    {
        public string Text { get; set; }
        public string CustomWord { get; set; }
        public SpellModel Model { get; set; }
        public string RequestType { get; set; }
        public string ErrorWord { get; set; }
    }
    public class SpellModel
    {
        public Boolean IgnoreAlphaNumericWords { get; set; }
        public Boolean IgnoreEmailAddress { get; set; }
        public Boolean IgnoreMixedCaseWords { get; set; }
        public Boolean IgnoreUpperCase { get; set; }
        public Boolean IgnoreUrl { get; set; }
        public Boolean IgnoreFileNames { get; set; }
    }
}