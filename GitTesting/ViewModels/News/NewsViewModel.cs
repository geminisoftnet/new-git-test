using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitTesting.ViewModels.News
{
    public class NewsViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
        public DateTime CreateDate { get; set; } 
    }
}