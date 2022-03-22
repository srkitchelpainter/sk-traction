using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// C# 70-483 Exam Competency: Working with variables, operators, and expressions
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/

namespace Sitecore.Feature.Fundamentals.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Calculator()
        {
            return View();
        }

        // C# 70-483 Exam Competency: Managing program flow and events.
            // https://docs.microsoft.com/en-us/dotnet/standard/events/
        [HttpPost]
        public ActionResult Calculator(string firstNumber, string secondNumber, string Cal)
        {
            int a = Int32.Parse(firstNumber);
            int b = Int32.Parse(secondNumber);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }
    }
}