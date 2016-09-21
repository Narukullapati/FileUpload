using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileUpload.Models;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/FileUpload

        public ActionResult FileUpload()
        {
            return View();

        }

        [HttpPost]

        public void Index(IEnumerable<HttpPostedFileBase> files, string command)
        {
            if (command == "upload")
            {
                if (files != null)
                {
                    foreach (var file in files)
                    {
                        // Verify that the user selected a file
                        if (file != null && file.ContentLength > 0)
                        {
                            // extract only the fielname
                            var fileName = Path.GetFileName(file.FileName);
                            // TODO: need to define destination
                            var path = Path.Combine(Server.MapPath("~/Upload"), fileName);
                            file.SaveAs(path);
                           
                        }
                    }
                }
                else
                {
                    
                }
                
            }
            else if (command == "save")
            {
                if (files != null)
                {
                    foreach (var file in files)
                    {
                        // Verify that the user selected a file
                        if (file != null && file.ContentLength > 0)
                        {
                            // extract only the fielname
                            var fileName = Path.GetFileName(file.FileName);
                            // TODO: need to define destination
                            var path = Path.Combine(Server.MapPath("~/Uploadr"), fileName);
                            file.SaveAs(path);
                        }
                    }
                }
              
                   
                
            }
           
        }

  
    }
}
