using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_2018._08._06
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenement = new Evenement();
            evenement.JourSemaine = JourSemaine.Lundi;

            Console.ReadKey();


        }
        public class Evenement
        { public JourSemaine JourSemaine { get; set; }
        }
        public enum JourSemaine
        {
            Lundi = 1,
            Mardi = 2,
            Mercredi = 3,
            Jeudi = 4,
            Vendredi = 5,
            Samedi = 6,
            Dimanche = 7
        }
    }
}
