﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _WCFIntro
{
    public class Matematik : IMatematik
    {
        public int Bol(int a, int b)
        {
            return a / b;
        }

        public int Carp(int a, int b)
        {
            return a * b;
        }

        public int Cikar(int a, int b)
        {
            return a - b;
        }

        public int Topla(int a, int b)
        {
            return a + b;
        }
    }
}
