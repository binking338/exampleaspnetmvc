using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVCModelBinder.Models
{
    [ModelBinder(typeof(FooModelBinder))]
    public class Foo
    {
        public string Name { get; set; }

        public string Desc { get; set; }
    }

    public class FooModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new Foo { Name = "Foo", Desc = DateTime.Now.ToString() };
        }
    }

    public class FoxModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new Foo { Name = "Fox", Desc = DateTime.Now.ToString() };
        }
    }
}