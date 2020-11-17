using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class FormClass
    {
        public FormClass()
        {
            UploadDefault = new List<IFormFile>();
        }
        public DateTime datepicker { get; set; }
        public string maskededit { get; set; }
        public IList<IFormFile> UploadDefault { get; set; }
    }
}