using Domain;
using Service.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WepApiUi.Areas.Ui
{
    public class HomeUiController : ApiController
    {

        [HttpGet]
        public object ObterListaHome()
        {
            return new SrvHome().ObterHomeUi();
        }

    }
}
