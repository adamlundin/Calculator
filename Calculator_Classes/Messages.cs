namespace Calculator_Classes
{
    public class Messages
    {
        public void StateNumber(string input)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            switch (input)
            {
                // between ±1.0 x 10^-28 to ±7.9228 x 10^28
                case "+":
                    Console.WriteLine("Type in TWO terms(on at a time):"); // difference
                    break;
                case "-":
                    Console.WriteLine("Type in TWO terms (on at a time):"); // sum
                    break;
                case "*":
                    Console.WriteLine("Type in TWO factors (on at a time):"); // produkt
                    break;
                case "/":
                    Console.WriteLine("Type a numerator followed by a denominator:"); // quota
                    break;
                case "c":
                    Console.WriteLine("Type a °F:");
                    break;
                case "f":
                    Console.WriteLine("Type a °C:");
                    break;
            }
            Console.ResetColor();
        }

        public void Text(string input, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        // Tried to do it like this first but then remebered there is a better way

        //public void YellowText(string input)
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(input);
        //    Console.ResetColor();
        //}
        //public void GreenText(string input)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine(input);
        //    Console.ResetColor();
        //}
        //public void BlueText(string input)
        //{
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Console.WriteLine(input);
        //    Console.ResetColor();
        //}
        //public void RedText(string input)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine(input);
        //    Console.ResetColor();
        //}     



    }
}
