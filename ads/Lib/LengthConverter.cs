using System.Diagnostics.Metrics;

namespace ads.Lib
{
    public class LengthConverter
    {
        public double ConvertToMeters(double value, string unit)
        {
            switch (unit.ToLower())
            {
                case "มิลลิเมตร":
                    return value / 1000;
                case "เซนติเมตร":
                    return value / 100;
                case "นิ้ว":
                    return value * 0.0254;
                case "ฟุต":
                    return value * 0.3048;
                     
                case "เมตร":
                    return value;
                case "กิโลเมตร":
                    return value * 1000;
                case "ไมล์":
                    return value * 1609.34;
                default:
                    throw new ArgumentException("หน่วยไม่ถูกต้อง");
            }
        }

        public double ConvertFromMeters(double value, string unit)
        {
            switch (unit.ToLower())
            {
                case "มิลลิเมตร":
                    return value * 1000;
                case "เซนติเมตร":
                    return value * 100;
                case "นิ้ว":
                    return value / 0.0254;
                case "ฟุต":
                    return value / 0.3048;
                case "เมตร":
                    return value;
                case "กิโลเมตร":
                    return value / 1000;
                case "ไมล์":
                    return value / 1609.34;
                default:
                    throw new ArgumentException("หน่วยไม่ถูกต้อง");
            }
        }
    }
}