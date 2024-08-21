// Namespace: ads
namespace ads
{
    public class UnitConverter
    {
        public double ConvertToMeters(double centimeters)
        {
            return centimeters / 100;
        }

        public double ConvertToKilometers(double centimeters)
        {
            return centimeters / 100000;
        }

        public double ConvertToInches(double centimeters)
        {
            return centimeters / 2.54;
        }

        public double ConvertToFeet(double centimeters)
        {
            return centimeters / 30.48;
        }
    }
}