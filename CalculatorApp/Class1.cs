namespace CalculatorApp 
{
    public class Calculator 
    {
        public double Add(double a, double b)// Метод сложения двух чисел
        {
            return a + b;
        }

        public double Subtract(double a, double b)// Метод вычитания двух чисел
        {
            return a - b;
        }

        public double Multiply(double a, double b)// Метод умножения двух чисел
        {
            return a * b;
        }

        public double Divide(double a, double b)// Метод деления двух чисел
        {
            if (b == 0)// Если делитель равен 0, то бросаем исключение т.к делить на 0 нельзя
                throw new DivideByZeroException("Делить на ноль нельзя");
            return a / b;// Если же делитель не равен 0, то выполняется деление
        }
    }
}
