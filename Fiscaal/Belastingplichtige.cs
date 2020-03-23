using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscaal
{
    internal class Belastingplichtige : IBelastingplichtige
    {
        public IPersoonsgegevens Persoonsgegevens { get; }
        public IPersoonsgegevens PersoonsgegevensPartner { get; }

        public List<Inkomen> Inkomens { get; }
        public List<Inkomen> InkomensPartner { get; }

    }

    internal interface IBelastingplichtige
    {
        IPersoonsgegevens Persoonsgegevens { get; }
        IPersoonsgegevens PersoonsgegevensPartner { get; }

        List<Inkomen> Inkomens { get; }
        List<Inkomen> InkomensPartner { get; }
    }
}
