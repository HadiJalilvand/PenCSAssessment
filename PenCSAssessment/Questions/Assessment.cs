using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PenCSAssessment.Questions
{
    public static class Assessment
    {
        /// <summary>
        /// Implement this method that takes a list of integers and returns the average
        /// </summary>
        public static double Average(List<int> list)
        {
            double sum = 0;
            list.ForEach(f =>
            {
                sum += f;
            });
            return sum / list.Count;
        }

        /// <summary>
        /// Implement this method that takes a list of Coordinate objects (see below) and 
        /// returns a list of Coordinate objects with those in the input list not matching int /// x and int y filtered out.
        /// </summary>
        public static List<Coordinate> GetMatchingCoordinates(List<Coordinate> coord, int x, int y)
        {

            return coord.Where(i => i.X == x && i.Y == y).ToList();

        }


        /// <summary>
        /// Implement this method that takes a list of string and replaces any characters
        /// in those strings that are in toRemove with a '*' character. Any strings in the 
        /// list
        /// that have all of their characters replaced with * should be removed from the list.
        /// ie, the input of:
        ///     strings = { "Michael", "Sandy", "Cheran", "Rashmi", "Markand" };
        ///     toRemove = ['M', 'i', 'c', 'a', 'l', 'h', 'e'];
        /// should return:
        ///     { "S*ndy", "C**r*n", "R*s*m*", "**rk*nd" }
        /// </summary>
        public static List<string> RemoveCharacters(List<string> strings, char[] toRemove)
        {
            List<string> result = new List<string>();
            strings.ForEach(f =>
            {
                int count = 0;
               
                for (int i = 0; i < toRemove.Length; i++)
                {
                    if (f.Contains(toRemove[i]))
                    {
                       f = f.Replace(toRemove[i], '*');
                        count++;
                    }
                }
                if (count != f.Length)
                {
                    result.Add(f);
                }
               
            });

            return result;
        }


        /// <summary>
        /// Write the output to the console of the following method
        /// </summary>
        public static void TrickQuestion()
        {
            int[] inOrderArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(inOrderArray, i => Console.Write(i));
        }




    }
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
