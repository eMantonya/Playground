﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVL24_The_Catacombs_of_the_Class
{
    internal class Color
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }  

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Green { get; } = new Color(0, 255, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color Purple { get; } = new Color(128, 0, 128);

        public void PrintRGBValues()
        {
            Console.WriteLine($"Red value = {R}, Green value = {G}, Blue value = {B}");
        }
    }


}