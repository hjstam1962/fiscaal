using System;
using System.Collections.Generic;
using System.Text;

namespace FiscaalExperiment1.Models.AanvragerModels
{
    internal class Aanvrager : IAanvrager
    {
        public Aanvrager(IInkomen inkomen)
        {
            Inkomen = inkomen;
        }
        public IInkomen Inkomen { get; }

        public override string ToString()
        {
            return string.Format("Jaarinkomen: {0}, soort inkomen: {1}, periode inkomen: {2} t/m {3}", 
                Inkomen.Jaarbedrag, Inkomen.Soort, Inkomen.Startdatum, Inkomen.Einddatum);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    internal interface IAanvrager
    {
        IInkomen Inkomen { get; }
    }
}
