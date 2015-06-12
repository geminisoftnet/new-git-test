using GitTesting.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTesting.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult RecentList()
        {
            var model = new List<NewsViewModel>(); 
            var r =new Random(); 
            var dtNow=DateTime.Now; 
            for(int i=0; i<10;i++)
            {
                var n = new NewsViewModel { Title="news-"+i, Published=true, CreateDate=dtNow.AddHours(r.Next(1,24)), Content="hello world"}; 
                model.Add(n);
            }

            return View(model.OrderByDescending(x=>x.CreateDate).ToList());
        }
	}
}