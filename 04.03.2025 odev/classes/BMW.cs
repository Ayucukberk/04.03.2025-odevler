using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04._03._2025_odev.Interface;

namespace _04._03._2025_odev.classes
{
    class BMW : IHareket
    {
        public void HizliGit() => Console.WriteLine("BMW çok hızlı gidiyor.");
        public void Yuz() => Console.WriteLine("BMW denizde yüzüyor.");
        public void Uc() => Console.WriteLine("BMW havada uçuyor.");
    }
}
