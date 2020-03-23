using System;
using System.Collections.Generic;
using System.Text;

namespace FiscaalExperiment1.Models.AanvragerModels
{
    internal class Inkomen : IInkomen
    {
        public Inkomen(InkomenType soort, decimal jaarbedrag, DateTime startdatum, DateTime einddatum)
        {
            Soort = soort;
            Jaarbedrag = jaarbedrag;
            Startdatum = startdatum;
            Einddatum = einddatum;
        }
        public InkomenType Soort { get; }
        public decimal Jaarbedrag { get; }
        public DateTime Startdatum { get; }
        public DateTime Einddatum { get; }

    }

    internal interface IInkomen
    {
        InkomenType Soort { get; }
        decimal Jaarbedrag { get; }
        DateTime Startdatum { get; }
        DateTime Einddatum { get; }
    }

    internal enum InkomenType
    {
        Arbeid = 0,
        Uitkering = 1
    }
}
