namespace OOP.Classes
{
    public class Calculator
    {
        public double qiymat1 { get; set; }
        public double qiymat2 { get; set; }

        public Calculator()
        {
            qiymat1 = 0;
            qiymat2 = 0;
        }
        public string Hisobla(double FirstNumber, double SecondNumber, string Operatorr)
        {
            string result = "";
            
            switch (Operatorr)
            {
                case "+":
                    result = Convert.ToString(FirstNumber + SecondNumber);
                    return result;
                    
                case "-":
                    result = Convert.ToString(FirstNumber - SecondNumber);
                    return result;
                case "*":
                    result = Convert.ToString(FirstNumber * SecondNumber);
                    return result;
                case "/":
                    result = Convert.ToString(FirstNumber / SecondNumber);
                    return result;
                    case "Null": result = "operatorni kiritmadingiz ";
                    return result;
                  
                default:
                    result = "+,-,*,/, operatorlaridan birini kiriting ";
                    return result;
            }
            
        }
    }
}