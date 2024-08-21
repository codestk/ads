// Controller: Converter

using ads.Models;
using Microsoft.AspNetCore.Mvc;

namespace ads.Controllers;

public class ConverterController : Controller
{
    private readonly LengthConverter _lengthConverter = new();

    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Convert(double value, string fromUnit, string toUnit)
    {
        var _result = "";

        var meters = _lengthConverter.ConvertToMeters(value, fromUnit);


 


        string[] AllUnit = { "กิโลเมตร", "เมตร", "เซนติเมตร", "มิลลิเมตร" };

        foreach (var _Unit in AllUnit)
        {
            var result = _lengthConverter.ConvertFromMeters(meters, _Unit);

            if (toUnit == _Unit)
            {

                _result += $"<p class=\"alert alert-light\">{value} {fromUnit} = {result} {_Unit}</p>";
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