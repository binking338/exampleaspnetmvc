using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVCModelBinder.Models
{
    public class Bar
    {
        public string Name { get; set; }

        public string Desc { get; set; }
    }
    public class BarModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new Bar { Name = "Bar", Desc = DateTime.Now.ToString() };
        }
    }
}