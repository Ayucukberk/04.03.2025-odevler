using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04._03._2025_odev.Interface;

namespace _04._03._2025_odev.classes
{
    class Porsche : IHareket
    {
        public void HizliGit() { }
        public void Yuz() { }
        public void Uc() => Console.WriteLine("Porsche havada uçuyor.");
    }
}
