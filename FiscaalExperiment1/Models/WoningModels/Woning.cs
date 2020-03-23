using System;
using System.Collections.Generic;
using System.Text;

namespace FiscaalExperiment1.Models.WoningModels
{
    internal class Woning : IWoning
    {
        public Woning(DateTime datumInBezit, decimal wozWaarde)
        {
            DatumInBezit = datumInBezit;
            WozWaarde = wozWaarde;
        }
        public DateTime DatumInBezit { get; }
        public decimal WozWaarde { get; }

        public override string ToString()
        {
            return string.Format("Datum in bezit: {0}, woz waarde: {1}", DatumInBezit, WozWaarde);
        }

    }

    internal interface IWoning
    {
        DateTime DatumInBezit { get; }
        decimal WozWaarde { get; }
    }
}
