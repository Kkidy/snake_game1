﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sum = '*';
            Draw(p1.x, p1.y, p1.sum);

            /*  int x1 = 1;
            int y1 = 3;
            char sum1 = '*'; 

            Draw(x1, y1, sum1); */

            int x2 = 4;
            int y2 = 5;
            char sum2 = '#';

            Draw(x2, y2, sum2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sum)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }
    }
}
