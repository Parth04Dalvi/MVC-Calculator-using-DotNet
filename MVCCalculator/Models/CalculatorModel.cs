namespace MVCCalculator.Models
{
    public class CalculatorModel
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operator { get; set; }
        public double? Result { get; set; }

        public void Calculate()
        {
            switch (Operator)
            {
                case "+":
                    Result = Num1 + Num2;
                    break;
                case "-":
                    Result = Num1 - Num2;
                    break;
                case "*":
                    Result = Num1 * Num2;
                    break;
                case "/":
                    Result = Num2 != 0 ? Num1 / Num2 : null;
                    break;
                default:
                    Result = null;
                    break;
            }
        }
    }
}
