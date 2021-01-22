using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ferhat";
            int yas = 36;

            Kurs kurs = new Kurs();
            kurs.KursAdi = "C#";
            kurs.Egitmen = "FERHAT";
            kurs.IzlenmeOrani = 70;


        }
    }
    class Kurs 
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    
}


