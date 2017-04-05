using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WepApiUi.Areas.Ui
{
    public class LoginUiController : ApiController
    {
        SrvUsuario _srvUsuario = new SrvUsuario();

        [HttpGet]
        public string Teste([FromUri] string teste)
        {
            Usuario usuario = new Usuario() { Nome = teste };
            _srvUsuario.Salvar(usuario);

            return "asdasdasdasd2";
        }
    }
}
