namespace OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckTemperature(38.5);
            CheckTemperature(38.5, 39.2, 38.1);
            CheckTemperature(35.7, tooLow: 35.3);
        }

        static void CheckTemperature(double temp, double tooHigh=37.5, double tooLow=35.8)
        {
            if (temp < tooHigh && temp > tooLow)
                Console.WriteLine("{0} stopnia - jesteś zdrowy!", temp);
            else
                Console.WriteLine("No tak, {0} stopnia - lepiej idź do lekarza!", temp);
        }
    }
}
