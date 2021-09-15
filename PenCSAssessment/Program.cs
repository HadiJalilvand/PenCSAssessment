using System;
using System.Collections.Generic;
using PenCSAssessment.Questions;

namespace PenCSAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 30, 50 };


            Console.WriteLine(Assessment.Average(list));
            //-------------------------------------------------------

            List<Coordinate> coordinateList = new List<Coordinate>();
            coordinateList.Add(new Coordinate() { X = 1, Y = 2 });
            coordinateList.Add(new Coordinate() { X = 3, Y = 4 });
            coordinateList.Add(new Coordinate() { X = 1, Y = 2 });

            coordinateList = Assessment.GetMatchingCoordinates(coordinateList, 1, 2);
            Console.WriteLine($"Coordinate = {coordinateList.ToArray()[0].X} , {coordinateList.ToArray()[0].Y} , Count: {coordinateList.ToArray().Length}");
            //----------------------------------------------------------------------------------------------------------------------------------------------------

            List<string> strings = new List<string> { "Michael", "Sandy", "Cheran", "Rashmi", "Markand" };
            char[] toRemove = new char[] { 'M', 'i', 'c', 'a', 'l', 'h', 'e' };
            strings = Assessment.RemoveCharacters(strings, toRemove);

            strings.ForEach(f => 
            {
                Console.WriteLine(f + ",");
            });

            Assessment.TrickQuestion();

            Console.ReadLine();

        }

    }
}
