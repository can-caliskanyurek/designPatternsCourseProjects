using System;
using System.Collections.Generic;
using System.Linq;

namespace FacadeCodingExercise
{
    public class Generator
    {
        private static readonly Random random = new Random();

        public List<int> Generate(int count)
        {
            return Enumerable.Range(0, count)
                .Select(_ => random.Next(1, 1))
                .ToList();
        }
    }

    public class Splitter
    {
        public List<List<int>> Split(List<List<int>> array)
        {
            var result = new List<List<int>>();

            var rowCount = array.Count;
            var colCount = array[0].Count;

            // get the rows
            for (int r = 0; r < rowCount; ++r)
            {
                var theRow = new List<int>();
                for (int c = 0; c < colCount; ++c)
                    theRow.Add(array[r][c]);
                result.Add(theRow);
            }

            // get the columns
            for (int c = 0; c < colCount; ++c)
            {
                var theCol = new List<int>();
                for (int r = 0; r < rowCount; ++r)
                    theCol.Add(array[r][c]);
                result.Add(theCol);
            }

            // now the diagonals
            var diag1 = new List<int>();
            var diag2 = new List<int>();
            for (int c = 0; c < colCount; ++c)
            {
                for (int r = 0; r < rowCount; ++r)
                {
                    if (c == r)
                        diag1.Add(array[r][c]);
                    var r2 = rowCount - r - 1;
                    if (c == r2)
                        diag2.Add(array[r][c]);
                }
            }

            result.Add(diag1);
            result.Add(diag2);

            return result;
        }
    }

    public class Verifier
    {
        public bool Verify(List<List<int>> array)
        {
            if (!array.Any()) return false;

            var expected = array.First().Sum();

            return array.All(t => t.Sum() == expected);
        }
    }

    public class MagicSquareGenerator
    {
        private readonly Generator _generator = new Generator();
        private readonly Splitter _splitter = new Splitter();
        private readonly Verifier _verifier = new Verifier();

        public List<List<int>> Generate(int size)
        {
            List<List<int>> matrix = new List<List<int>>();
            List<List<int>> splittedMatrix = new List<List<int>>();

            while (true)
            {
                for (int i = 0; i < size; i++)
                {
                    List<int> row = _generator.Generate(size);
                    matrix.Add(row);
                }

                splittedMatrix = _splitter.Split(matrix);
                bool result = _verifier.Verify(splittedMatrix);

                if (result)
                    return matrix;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> magicSquare = new List<List<int>>();
            MagicSquareGenerator magicSquareGenerator = new MagicSquareGenerator();

            magicSquare = magicSquareGenerator.Generate(3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(magicSquare[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
