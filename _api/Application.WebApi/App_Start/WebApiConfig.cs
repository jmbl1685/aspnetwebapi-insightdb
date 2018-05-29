using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Application.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var bodyFormat = config.Formatters;
            bodyFormat.Remove(bodyFormat.XmlFormatter);

            config.EnableCors();
            config.MapHttpAttributeRoutes();

        }
    }
}
