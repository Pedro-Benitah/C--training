using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes.Entities
{
    static internal class Matriz
    {
        public static int[,] Mat;
        private static int[] Position = new int[2];

        private static string Up()
        {
            if (Position[0] != 0)
            {
                return $"\nUp: {Mat[Position[0] - 1, Position[1]]}";
            }
            return "";
        }
        private static string Down()
        {
            if (Position[0] != Mat.GetLength(0) - 1)
            {
                return $"\nDown: {Mat[Position[0]+1, Position[1]]}";
            }
            return "";
        }
        private static string Left()
        {
            if (Position[1] != 0)
            {
                return $"\nLeft: {Mat[Position[0], Position[1] - 1]}";
            }
            return "";
        }
        private static string Right()
        {
            if (Position[1] != Mat.GetLength(1) - 1)
            {
                return $"\nRight: {Mat[Position[0], Position[1] + 1]}";
            }
            return "";
        }
        public static string PrintValor(params int[] numbers)
        {
            Position = numbers;
            return "Position "
                + $"{numbers[0]},{numbers[1]}:"
                + Left()
                + Right()
                + Up()
                + Down();
        }
    }
}
