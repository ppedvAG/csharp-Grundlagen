﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Classes
{
    public class Detail
    {
        public enum Einheit
        {
            cm, m
        }
        // Props
        // in cm
        public double Höhe { get; set; }
        public double Breite { get; set; }
        public Einheit DefaultEinheit { get; }
        
        // ctors
        public Detail()
        {
        }
        public Detail(double h, double b)
        {
            Höhe = h;
            Breite = b;
            DefaultEinheit = Einheit.cm;
        }

        // methods
        public void SetHöhe(double h, Einheit e)
        {
            if (e == Einheit.cm)
            {
                Höhe = h;
            }
            else
            {
                Höhe = Umrechnung.MToCm(h);
            }
        }

        public static void SagHalloStatic()
        {
            Console.WriteLine("Hallo");
        }
        public void SagHallo()
        {
            Console.WriteLine("Hallo");
        }
    }
}
