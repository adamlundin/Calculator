namespace Calculator_Classes
{
    public class Calculate
    {
        public (string, decimal) Calculating(string op, decimal firstNumber, decimal secondNumber = 0)
        {
            Messages message = new Messages();
            decimal ecuals = 0;
            string textOutput = "HOW DID YOU GET HERE?";
            switch (op)
            {
                case "+":
                    ecuals = firstNumber + secondNumber;
                    textOutput = $"{firstNumber} + {secondNumber} = {ecuals.ToString("0.000")}";
                    return (textOutput, ecuals);
                case "-":
                    ecuals = firstNumber - secondNumber;
                    textOutput = $"{firstNumber} - {secondNumber} = {ecuals.ToString("0.000")}";
                    return (textOutput, ecuals);
                case "*":
                    ecuals = firstNumber * secondNumber;
                    textOutput = $"{firstNumber} * {secondNumber} = {ecuals.ToString("0.000")}";
                    return (textOutput, ecuals);
                case "/":
                    ecuals = firstNumber / secondNumber;
                    textOutput = $"{firstNumber} / {secondNumber} = {ecuals.ToString("0.000")}";
                    return (textOutput, ecuals);
                case "c":
                    ecuals = (firstNumber - 32) * (1/1.8M);
                    textOutput = $"{firstNumber}°F = {ecuals.ToString("0.0")}°C";
                    return (textOutput, ecuals);
                case "f":
                    ecuals = firstNumber * 1.8M + 32;
                    textOutput = $"{firstNumber}°C = {ecuals.ToString("0.0")}°F";
                    return (textOutput, ecuals);
                default: return (textOutput, ecuals);
            }
        }
    }
}
