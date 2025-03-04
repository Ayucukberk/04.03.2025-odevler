// See https://aka.ms/new-console-template for more information
using _04._03._2025_odev.classes;
using _04._03._2025_odev.Interface;

class Program
{
    static void Main()
    {
        IHareket bmw = new BMW();
        bmw.HizliGit();
        bmw.Yuz();
        bmw.Uc();

        IHareket mercedes = new Mercedes();
        mercedes.Yuz();
        mercedes.Uc();

        IHareket porsche = new Porsche();
        porsche.Uc();
    }
}
