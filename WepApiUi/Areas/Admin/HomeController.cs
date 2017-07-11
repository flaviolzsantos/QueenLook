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
    }
}
