﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library
{
    static class Umrechnung
    {
        public static double CmToM(double cm)
        {
            return cm * 0.01;
        }

        public static double MToCm(double m)
        {
            return m * 100;
        }
    }
}