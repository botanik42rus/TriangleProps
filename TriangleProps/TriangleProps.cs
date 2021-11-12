using System;
using System.Linq;

namespace Triangle
{
    public class TriangleProps
    {
        
        /// <summary>
        /// Метод для определения типа треугольника. 
        /// Так как в ТЗ явно не написано как остальное приложение должно было получить тип треугольника, то я выбрал тип String.
        /// </summary>
        /// <param name="sideA">Сторона 1</param>
        /// <param name="sideB">Сторона 2</param>
        /// <param name="sideC">Сторона 3</param>
        /// <returns></returns>
        public static string GetTrinagleType(double sideA, double sideB, double sideC)
        {
            if (sideA == sideB && sideA == sideC)
                return "Равносторонний";

            double[] SortedSides = new double[] { sideA, sideB, sideC }.OrderBy(i => i).ToArray();

            double Cat1 = SortedSides[0], 
                Cat2 = SortedSides[1], 
                Hypotenuse = SortedSides[2];

            if (((Cat1 * Cat1) + (Cat2 * Cat2)) == (Hypotenuse * Hypotenuse))
            {
                return "Прямоугольный";
            }
            else if (Cat1 <= 0 || Cat2 <= 0 || Hypotenuse <=0 || ((Cat1 + Cat2) <= (Hypotenuse)))
            {
                return "Не треугольник";
            }

            return ( (Cat2*Cat2) + (Cat1 * Cat1) ) > (Hypotenuse * Hypotenuse)  ? "Остроугольный": "Тупоугольный";
        }
    }
}
