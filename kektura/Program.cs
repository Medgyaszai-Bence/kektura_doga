using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kektura
{
    class Program
    {
        static List<string> kezdoPont = new List<string>();
        static List<string> vegPont = new List<string>();
        static List<double> szakaszHossz = new List<double>();
        static List<int> emelkedes = new List<int>();
        static List<int> lejtes = new List<int>();
        static List<char> pHely = new List<char>();

        static void Main(string[] args)
        {
            //2.feladat
            StreamReader sr = new StreamReader("kektura.csv", Encoding.Default);

            int kezd = Convert.ToInt32(sr.ReadLine());
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                kezdoPont.Add(adatok[0]);
                vegPont.Add(adatok[1]);
                szakaszHossz.Add(Convert.ToDouble(adatok[2]));
                emelkedes.Add(Convert.ToInt32(adatok[3]));
                lejtes.Add(Convert.ToInt32(adatok[4]));
                pHely.Add(Convert.ToChar(adatok[5]));
            }
            sr.Close();


            //3.Feladat

            Console.WriteLine("3. feladat Szakaszok száma: " + szakaszHossz.Count + " db");


            //4.feladat
            double teljesHossz = 0;
            for (int i = 0; i < szakaszHossz.Count; i++)
            {
                teljesHossz = teljesHossz + szakaszHossz[i];
            }
            Console.WriteLine("4. feladat A túra teljes hossza: " + teljesHossz + " km");


            //5.feladat
            int legrovidebb = 0;
            for (int i = 1; i < szakaszHossz.Count; i++)
            {
                if (szakaszHossz[i] < legrovidebb)
                {
                    legrovidebb = i;
                }
            }
            Console.WriteLine("5. feladat A legrövidebb szakasz adatai:");
            Console.WriteLine("Kezdete: " + kezdoPont[legrovidebb]);
            Console.WriteLine("Vége: " + vegPont[legrovidebb]);
            Console.WriteLine("Távolság: " + szakaszHossz[legrovidebb] + " km");
            
        }

        public bool HianyosNev() {
            return true;
        }
    }
}
