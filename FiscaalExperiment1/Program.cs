using FiscaalExperiment1.Models.AanvragerModels;
using FiscaalExperiment1.Models.LeningModels;
using FiscaalExperiment1.Models.WoningModels;
using System;

namespace FiscaalExperiment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maak API-objecten
            var aanvrager = new Aanvrager(new Inkomen(InkomenType.Arbeid, 30000m, new DateTime(2000, 1, 1), new DateTime(2040, 1, 1)));
            var lening = new Lening(100_000m, 0.01m, new DateTime(2020, 1, 1), 120, LeningType.Lineair);
            var woning = new Woning(new DateTime(2020, 3, 1), 200_000);
            Console.WriteLine("Aanvrager: {0}", aanvrager.ToString());
            Console.WriteLine("Lening: {0}", lening);
            Console.WriteLine("Woning: {0}", woning);


        }
    }
}
