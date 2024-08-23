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
    public ActionResult Index(ConverterModel model)
    {



        return View(model);
    }

    [HttpPost]
    public ActionResult Convert(double value, string fromUnit, string toUnit)
    {
         

        var meters = _lengthConverter.ConvertToMeters(value, fromUnit);


        //var AllUnit = ConverterModel.Options;


        //var AllUnit = ConverterModel.Options
        //    .OrderByDescending(s => s.StartsWith(toUnit))
        //    .ThenBy(s => s);



       List<ConverterModel> ls=new List<ConverterModel>();
        foreach (var _toUnit in ConverterModel.Options)
        {
            var result = _lengthConverter.ConvertFromMeters(meters, _toUnit);

            ConverterModel mt = new ConverterModel();
            mt.Centimeter = meters;
            mt.fromUnit = fromUnit;
            mt.toUnit = _toUnit;
            mt.Result = result.ToString("#,##0.000");
            ls.Add(mt);


            //if (toUnit == _toUnit)
            //{
            //    _result += $"<p class=\"alert alert-light\">{value} {fromUnit} = {mt.Result} {_toUnit}</p>";
            //}
            //else if (fromUnit == _toUnit)
            //{
            //    //skip
            //}
            //else
            //{
            //    _result += $"<p>{value} {fromUnit} = {mt.Result} {_toUnit} </p>";
            //}
        }

          
        ViewBag.AllResult = ls;

        ViewBag.InputValue = value; // เก็บค่าที่กรอกไว้ใน ViewBag
        ViewBag.fromUnit = fromUnit;
        ViewBag.toUnit = toUnit;
       

        return View("index");

        //return RedirectToAction("Index");
    }
}