﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Composite
{
    public class After
    {
        public static void Run()
        {
            IShape[] shapes =
               { 
                   new LineShape() { Adoptee = new LegacyLine() },
                   new RectangleShape() { Adoptee = new LegacyRectangle () }
               };

            // A begin and end point from a graphical editor
            int x1 = 10, y1 = 20;
            int x2 = 30, y2 = 60;
            for (int i = 0; i < shapes.Length; ++i)
            {
                // no casting or special conversions to use our shapes:
                shapes[i].draw(x1, y1, x2, y2);
            }
        }
    }

    // We decalre a common interface, which represents the desired target:
    interface IShape
    {
        // a draw method that takes two points:
        void draw(int x1, int y1, int x2, int y2);
    }

    // An object adapter from IShape to Line
    class LineShape : IShape
    {
        public LegacyLine Adoptee { get; set; }
        public void draw(int x1, int y1, int x2, int y2)
        {
            // straight-forward delegation:
            Adoptee.Draw(x1, y1, x2, y2);
        }
    }

    // An object adapter from IShape to Rectangle
    public class RectangleShape : IShape
    {
        public LegacyRectangle Adoptee { get; set; }

        public void draw(int x1, int y1, int x2, int y2)
        {
            // convert the two points to: top/left, width, height:
            Adoptee.Draw(
                Math.Min(x1, x2),
                Math.Min(y1, y2),
                Math.Abs(x2 - x1),
                Math.Abs(y2 - y1));
        }
    }
}
