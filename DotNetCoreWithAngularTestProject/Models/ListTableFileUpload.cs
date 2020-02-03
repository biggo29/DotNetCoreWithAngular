using DotNetCoreWithAngularTestProject.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWithAngularTestProject.Models
{
    public class ListTableFileUpload
    {
        public int listTableId { get; set; }
        public int tradeId { get; set; }
        public int levelId { get; set; }
        public string syllabusName { get; set; }
        public string syllabusFilePath { get; set; }
        public string testPlanFilePath { get; set; }
        public string language { get; set; }
        public string developmentOfficer { get; set; }
        public string manager { get; set; }
        public DateTime activeDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool status { get; set; }
        public IFormFile file { get; set; }
    }
}
