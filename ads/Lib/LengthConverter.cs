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
                case "เมตร":
                    return value;
                case "กิโลเมตร":
                    return value * 1000;
                default:
                    throw new ArgumentException("Invalid fromUnit");
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
                case "เมตร":
                    return value;
                case "กิโลเมตร":
                    return value / 1000;
                default:
                    throw new ArgumentException("Invalid toUnit");
            }
        }
    }
}