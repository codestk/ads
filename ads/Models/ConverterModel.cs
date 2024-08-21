using Microsoft.AspNetCore.Mvc.Rendering;

namespace ads.Models
{
    public class ConverterModel
    {
        public double Centimeter { get; set; }
        public string Unit { get; set; }
        public string Result { get; set; }


        public static List<string> Options = new List<string> { "มิลลิเมตร", "เซนติเมตร", "นิ้ว", "เมตร", "กิโลเมตร" };
        public string SelectedOption { get; set; }

    }
}
