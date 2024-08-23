using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ads.Models
{
    public class ConverterModel
    {

 


        public string fromUnit { get; set; }
        public double Centimeter { get; set; }
      

         public string toUnit { get; set; }
        public string Result { get; set; }


        public static List<string> Options = new List<string> { "เซนติเมตร", "นิ้ว", "มิลลิเมตร", "ฟุต", "เมตร", "กิโลเมตร", "ไมล์" };
        public string SelectedOption { get; set; }

    }
}
