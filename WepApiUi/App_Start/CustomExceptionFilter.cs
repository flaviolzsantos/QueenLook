using Domain;
using Service.Sistema;
using System;
using System.Net;  
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Web.Routing;
using Util.Exceptions;

namespace WepApiUi.App_Start
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
                
            object obj;
            actionExecutedContext.ActionContext.ControllerContext.RouteData.Values.TryGetValue("controller", out obj);
            string controllerName = obj.ToString();
            
            HttpControllerContext controllerContext = actionExecutedContext.ActionContext.ControllerContext;
            try
            {
                if (!(actionExecutedContext.Exception is RegraNegocioException))
                {
                    Erro erro = new Erro(controllerName, TipoErro.Ajax, actionExecutedContext.Exception.Message);
                    new SrvErro().SalvarErro(erro);
                }
            }
            catch (Exception e) { }
            
        }

    }
}