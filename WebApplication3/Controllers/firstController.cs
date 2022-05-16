using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace WebApplication3.Controllers
{
    public class firstController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.User1 = "張三";
           object  viewName = "田七";
            System.Diagnostics.Debug.WriteLine("大家好");
            CustomDbContext mycontext  = new CustomDbContext();
            GISTest mygistest = new GISTest();
            PostSqlContext postSqlContext = new PostSqlContext();
            var sqlstring = "SELECT gid,json_build_object ('a', 'a','geometry', ST_AsGeoJSON(geog)::json) AS countyname  FROM town_moi_1100415 WHERE gid=1";
            
            var searchdata = postSqlContext.town_moi_1100415.FromSqlRaw(sqlstring);
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            
            // string jsonString = JsonSerializer.Serialize(searchdata);
           
            //System.Diagnostics.Debug.WriteLine(jsonString);
            // var searchdata = postSqlContext.town_moi_1100415.Where(x => x.townid == "V02").Select(y => y.geog).FirstOrDefault();
            // System.Diagnostics.Debug.WriteLine(searchdata);
            //var searchdata = mygistest.TOWN_MOI_1100415.Where(x => x.countyname == "臺中市").Select(y=>y.countyname);

            //var one =  from score in mygistest.TOWN_MOI_1100415
            //          where score.countyname == "臺東縣" 
            //            select score.countyname;
            //System.Diagnostics.Debug.WriteLine("我");
            //foreach (var n in searchdata)
            //{
            //    System.Diagnostics.Debug.WriteLine(n);
            //}
            //System.Diagnostics.Debug.WriteLine("你");
            // mygistest.Taiwan.Add(new Taiwan
            // {
            //   UserId = 123,
            //      Title = "tests",
            //     Content ="goods",
            //     Read = 1
            // });
            //  mygistest.SaveChanges();
            // mycontext.Post.Add(new Post
            // {
            //   UserId = 123,
            //   Title = "test",
            //    Content ="good",
            //    Read = 1
            //  });
            // mycontext.SaveChanges();

            foreach (var item in mycontext.Post)
            {
                System.Diagnostics.Debug.WriteLine(item.Content);
            }
            //foreach (var line in mycontext.Post)
            // {
            //    System.Diagnostics.Debug.WriteLine(line);
            //Do something
            //  }
           // ViewBag.products = jsonString;
                return View(searchdata);
        }
        
    }
}