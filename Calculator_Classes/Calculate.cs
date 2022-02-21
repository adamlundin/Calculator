namespace Calculator_Classes
{
    public class Calculate
    {
        /// <summary>
        /// Makes sure the right ecuation runs
        /// </summary>
        /// <param name="op">Operator</param>
        /// <param name="firstNumber">the first number in the ecuation</param>
        /// <param name="secondNumber">the second number in the ecuation</param>
        /// <returns></returns>
        public (string, decimal) Calculating(string op, decimal firstNumber, decimal secondNumber = 0)
        {
            decimal ecuals = 0;
            string textOutput = "HOW DID YOU GET HERE?";
            switch (op)
            {
                case "+":
                    return Addition(firstNumber, secondNumber);
                case "-":
                    return Subtraction(firstNumber, secondNumber);
                case "*":
                    return Multiplication(firstNumber, secondNumber);
                case "/":
                    return Divide(firstNumber, secondNumber);
                case "c":
                    return FarenheitToCelcius(firstNumber);
                case "f":
                    return CelciusToFarenheit(firstNumber);
                default: return (textOutput, ecuals);
            }
        }
        // I could have had these private but schoose to have them public so i could test them
        /// <summary>
        /// Adds two terms together
        /// </summary>
        /// <param name="firstTerm">first term in the ecuation</param>
        /// <param name="secondTerm">second term in the ecuation</param>
        /// <returns></returns>
        public (string, decimal) Addition(decimal firstTerm, decimal secondTerm)
        {
            decimal sum = firstTerm + secondTerm;
            string textOutput = $"{firstTerm} + {secondTerm} = {sum.ToString("0.000")}";
            return (textOutput, sum);
        }
        /// <summary>
        /// Subtracts the firstTerm with the secondTerm
        /// </summary>
        /// <param name="firstTerm">first term in the ecuation</param>
        /// <param name="secondTerm">second term in the ecuation</param>
        /// <returns></returns>
        public (string, decimal) Subtraction(decimal firstTerm, decimal secondTerm)
        {
            decimal difference = firstTerm - secondTerm;
            string textOutput = $"{firstTerm} - {secondTerm} = {difference.ToString("0.000")}";
            return (textOutput, difference);
        }
        /// <summary>
        /// Multiplies two factors together
        /// </summary>
        /// <param name="firstFactor">first factor in the ecution</param>
        /// <param name="secondFactor">second factor in the ecuation</param>
        /// <returns></returns>
        public (string, decimal) Multiplication(decimal firstFactor, decimal secondFactor)
        {
            decimal produkt = firstFactor * secondFactor;
            string textOutput = $"{firstFactor} * {secondFactor} = {produkt.ToString("0.000")}";
            return (textOutput, produkt);
        }
        /// <summary>
        /// Divides the numerator by the denominator
        /// </summary>
        /// <param name="numerator">the numerator in the ecuation</param>
        /// <param name="denominator">the denominator in the ecuation</param>
        /// <returns></returns>
        public (string, decimal) Divide(decimal numerator, decimal denominator)
        {
            decimal quota = numerator / denominator;
            string textOutput = $"{numerator} / {denominator} = {quota.ToString("0.000")}";
            return (textOutput, quota);
        }
        /// <summary>
        /// Calculates Farenheit to Celcius
        /// </summary>
        /// <param name="farenheit"></param>
        /// <returns></returns>
        public (string, decimal) FarenheitToCelcius(decimal farenheit)
        {
            decimal celcius = (farenheit - 32) * (1 / 1.8M);
            string textOutput = $"{farenheit}°F = {celcius.ToString("0.0")}°C";
            return (textOutput, celcius);
        }
        /// <summary>
        /// Calculates Celcius to Farenheit
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns></returns>
        public (string, decimal) CelciusToFarenheit(decimal celcius)
        {
            decimal farenheit = celcius * 1.8M + 32;
            string textOutput = $"{celcius}°C = {farenheit.ToString("0.0")}°F";
            return (textOutput, farenheit);
        }
    }
}
