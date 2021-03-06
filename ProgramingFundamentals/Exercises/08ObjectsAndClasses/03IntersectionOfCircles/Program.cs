﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Circle circle1 = new Circle();
            circle1.Center = new Point();
            circle1.Center.X = input[0];
            circle1.Center.Y = input[1];
            circle1.Radius = input[2];

            input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Circle circle2 = new Circle();
            circle2.Center = new Point();
            circle2.Center.X = input[0];
            circle2.Center.Y = input[1];
            circle2.Radius = input[2];

            if (circle1.isIntersected(circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }         
        }   
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
        

        public bool isIntersected(Circle circle)
        {
            double distance = Math.Sqrt(Math.Abs(circle.Center.X - Center.X) * Math.Abs(circle.Center.X - Center.X)) +
                Math.Sqrt(Math.Abs(circle.Center.Y - Center.Y) * Math.Abs(circle.Center.Y - Center.Y));

            if (distance <= circle.Radius + Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
