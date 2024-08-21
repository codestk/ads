// Controller: Converter

using ads.Lib;
using ads.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace ads.Controllers;

public class ConverterController : Controller
{
    private readonly LengthConverter _lengthConverter = new();

    [HttpGet]
    public ActionResult Index()
    {

      
        // Repopulate the options
      

        //model.Options = new List<string> { "Option 1", "Option 2", "Option 3" };
        return View();
    }

    [HttpPost]
    public ActionResult Convert(double value, string fromUnit, string toUnit)
    {
        var _result = "";

        var meters = _lengthConverter.ConvertToMeters(value, fromUnit);


        //var AllUnit = ConverterModel.Options;


        //var AllUnit = ConverterModel.Options
        //    .OrderByDescending(s => s.StartsWith(toUnit))
        //    .ThenBy(s => s);




        foreach (var _Unit in ConverterModel.Options)
        {
            var result = _lengthConverter.ConvertFromMeters(meters, _Unit);

            if (toUnit == _Unit)
            {
                _result += $"<p class=\"alert alert-light\">{value} {fromUnit} = {result} {_Unit}</p>";
            }
            else if (fromUnit == _Unit)
            {
                //skip
            }
            else
            {
                _result += $"<p>{value} {fromUnit} = {result} {_Unit} </p>";
            }
        }


        ViewBag.Result = _result;
        //ViewBag.Result = $"{value} {fromUnit} = {result} {toUnit}";

        return View("Index");
    }
}