namespace BMIberegner
{
    internal class Program
    {
        public static double Weight { get; set; }
        public static double Height { get; set; }
        static void Main()
        {
            // Checking if the two inputs can be parsed to double
            Console.Write("Your weight in kg: ");
            string WeightInput = Console.ReadLine()!;
            if (double.TryParse(WeightInput, out double OutWeight)) { Weight = OutWeight; } else { Invalid(); }
            Console.Write("Your height in cm: ");
            string HeightInput = Console.ReadLine()!;
            if (double.TryParse(HeightInput, out double OutHeight)) { Height = OutHeight; } else { Invalid(); }
            Console.Clear();

            // Calculating BMI
            double BMI = Math.Round((Weight / (Height/100 * Height/100)), 1);

            // Control structure to figure out where in the spectrum the person's BMI is
            if (BMI < 18.5)
            {
                Console.Write("Your BMI is ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{BMI}");
                Console.ResetColor();
                Console.Write(". You are in the body weight deficit range.");
            }
            else if (BMI < 24 && BMI > 18.5)
            {
                Console.Write("Your BMI is ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{BMI}");
                Console.ResetColor();
                Console.Write(". You are in the normal weight range.");
            }
            else if (BMI < 30 && BMI > 24)
            {
                Console.Write("Your BMI is ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{BMI}");
                Console.ResetColor();
                Console.Write(". You are in the over weight range.");
            }
            else if (BMI < 35 && BMI > 30)
            {
                Console.Write("Your BMI is ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{BMI}");
                Console.ResetColor();
                Console.Write(". You are in the first degree obesity range.");
            }
            else if (BMI < 40 && BMI > 35)
            {
                Console.Write("Your BMI is ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{BMI}");
                Console.ResetColor();
                Console.Write(". You are in the second degree obesity range.");
            }
            else
            {
                Console.Write("Your BMI is ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{BMI}");
                Console.ResetColor();
                Console.Write(". You are in the third degree obesity range.");
            }

            // Awaiting key
            Console.ReadKey();
            Console.Clear();
            Main();

            // The given value was not valid
            static void Invalid()
            {
                Console.Clear();
                Console.WriteLine("Invalid value");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
    }
}