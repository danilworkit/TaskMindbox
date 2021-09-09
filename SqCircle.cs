using System;

namespace Square
{
    public class SqCircle
    {
        public double CalcSquareC(double r)
        {
            if (r > 0)
            {
                double sq = 3.14 * Math.Pow(r, 2);
                Console.WriteLine($"Радиус: {r}\nПлощадь круга: {sq}\n");
                return sq;
            }
            else
            {
                Console.WriteLine($"Радиус: {r} \nОшибка ввода!\n");
                return -1;
            }
        }
    }

    public class SqTraingle
    {
        public double CalcSquareT(double a, double b, double c)
        {
            Console.WriteLine($"Стороны треугольника: {a}, {b}, {c}");
            double[] mas = new double[] {a,b,c};
            foreach (var elmas in mas)
            {
                if (elmas <= 0)
                {
                    Console.WriteLine("Ошибка ввода!\n");
                    return -1;
                }
            }
            Check_Right_Tri(mas);
            double p = (a + b + c) / 2;
            double sq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {sq}");
            return sq;
        }

        public void Check_Right_Tri(double[] mas)
        {
            Array.Sort(mas);
            if (mas[2] == Math.Sqrt(Math.Pow(mas[1], 2) + Math.Pow(mas[0], 2)))
                Console.WriteLine("Прямоугольный треугольник");
            else
                Console.WriteLine("Непрямоугольный треугольник");
        }
    }
}
