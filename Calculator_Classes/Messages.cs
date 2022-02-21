namespace Calculator_Classes
{
    public class Messages
    {
        /// <summary>
        /// Depending on what operator the user used the text will be different
        /// </summary>
        /// <param name="input">user input operator</param>
        public void StateNumber(string input)
        {
            switch (input)
            {
                case "+":
                    Text("Type in TWO terms (one at a time):", ConsoleColor.Blue);
                    break;
                case "-":
                    Text("Type in TWO terms (one at a time):", ConsoleColor.Blue);
                    break;
                case "*":
                    Text("Type in TWO factors (one at a time):", ConsoleColor.Blue);
                    break;
                case "/":
                    Text("Type a numerator followed by a denominator:", ConsoleColor.Blue);
                    break;
                case "c":
                    Text("Type a °F:", ConsoleColor.Blue);
                    break;
                case "f":
                    Text("Type a °C:", ConsoleColor.Blue);
                    break;
            }
        }
        /// <summary>
        /// Sets the color of the console text
        /// </summary>
        /// <param name="input">Text that should be colord</param>
        /// <param name="color">Clor of the text</param>
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
