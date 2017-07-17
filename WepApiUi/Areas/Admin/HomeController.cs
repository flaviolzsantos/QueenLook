using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain;
using System.Web.Http.Cors;
using Service.Ui;
using WepApiUi.App_Start;
using System.Web;

namespace WepApiUi.Areas.Admin
{
    [CustomExceptionFilter]
    public class HomeController : ApiController
    {
        
        [HttpPost]
        public void CadastrarHome(Home home)
        {
            new SrvHome().SalvarHome(home);
        }

        [HttpGet]
        public Home[] ObterListaHome()
        {
            return new SrvHome().ObterListaHome();
        }
       
        [HttpPost]
        public void Deletar([FromBody]int id)
        {            
            new SrvHome().DeletarHome(id);
        }

        [HttpPost]
        public void AtivarOuDesativar([FromBody] int id)
        {
            new SrvHome().AtivarOuDesativar(id);
        }

        [HttpPost]
        public void UploadFile()
        {
            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
                // Get the uploaded image from the Files collection
                var httpPostedFile = HttpContext.Current.Request.Files["files"];

                //if (httpPostedFile != null)
                //{
                //    // Validate the uploaded image(optional)

                //    // Get the complete file path
                //    var fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles"), httpPostedFile.FileName);

                //    // Save the uploaded file to "UploadedFiles" folder
                //    httpPostedFile.SaveAs(fileSavePath);
                //}
            }
        }
    }
}
