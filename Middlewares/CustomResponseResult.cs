using CutomApiLib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CutomApiLib.Middlewares
{
    public class CustomResponseResult : Attribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {

            if (context.Result is ObjectResult objectResult)
            {

                if (objectResult.StatusCode != 200)
                {
                    objectResult.Value = new CustomResponseModel
                    {
                        status = (int)objectResult.StatusCode,
                        title = objectResult.StatusCode.ToString(),
                        errors = objectResult.Value
                    };
                }
                else
                {
                    objectResult.Value = new CustomResponseModel
                    {
                        status = (int)objectResult.StatusCode,
                        data = objectResult.Value
                    };
                }

            }
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            
        }


    }
}
