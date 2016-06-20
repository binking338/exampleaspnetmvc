using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVCModelBinder.Models
{
    public class Lee
    {
        public string Name { get; set; }

        public string Desc { get; set; }
    }

    public class LeeModelBinder: IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new Lee { Name = "Lee", Desc = DateTime.Now.ToString() };
        }
    }

    public class MyModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(Type modelType)
        {
            if(modelType == typeof(Lee))
            {
                return new LeeModelBinder();
            }
            else
            {
                return null;
            }
        }
    }
}