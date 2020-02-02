using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Model
{
    public class ListTable
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
    }
}
