using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04._03._2025_odev.Interface;

namespace _04._03._2025_odev.classes
{
    class Mercedes : IHareket
    {
        public void HizliGit() { }
        public void Yuz() => Console.WriteLine("Mercedes denizde yüzüyor.");
        public void Uc() => Console.WriteLine("Mercedes havada uçuyor.");
    }
}
