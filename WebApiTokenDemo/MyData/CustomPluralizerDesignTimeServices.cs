using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiTokenDemo.MyData
{
    public class CustomPluralizerDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            services.AddSingleton<IPluralizer, CustomPluralizer>();
        }
    }

    public class CustomPluralizer : IPluralizer
    {
        public string Pluralize(string name)
        {
            return Inflector.Inflector.Pluralize(name) ?? name;
        }

        public string Singularize(string name)
        {
            string ret;

            switch (name)
            {
                //case "Banks":
                //    ret = "Bank";
                //    break;
                default:
                    ret = Inflector.Inflector.Singularize(name) ?? name;
                    break;
            }

            return ret;
        }
    }




}
