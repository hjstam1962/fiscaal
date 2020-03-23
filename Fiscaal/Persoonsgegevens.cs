using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscaal
{
    internal class Persoonsgegevens : IPersoonsgegevens
    {
        public string Naam { get; }
        public DateTime Geboortedatum { get; }
        public int Burgerservicenummer { get; }

    }

    internal interface IPersoonsgegevens
    {
        string Naam { get; }
        DateTime Geboortedatum { get; }
        int Burgerservicenummer { get; }
    }
}
