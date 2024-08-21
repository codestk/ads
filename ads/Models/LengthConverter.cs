namespace ads.Models
{
    public class LengthConverter
    {
        public double ConvertToMeters(double value, string unit)
        {
            switch (unit.ToLower())
            {
                case "กิโลเมตร":
                    return value * 1000;
                case "เมตร":
                    return value;
                case "เซนติเมตร":
                    return value / 100;
                case "มิลลิเมตร":
                    return value / 1000;
                default:
                    throw new ArgumentException("หน่วยไม่ถูกต้อง");
            }
        }

        public double ConvertFromMeters(double value, string unit)
        {
            switch (unit.ToLower())
            {
                case "กิโลเมตร":
                    return value / 1000;
                case "เมตร":
                    return value;
                case "เซนติเมตร":
                    return value * 100;
                case "มิลลิเมตร":
                    return value * 1000;
                default:
                    throw new ArgumentException("หน่วยไม่ถูกต้อง");
            }
        }
    }
}