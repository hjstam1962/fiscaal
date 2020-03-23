using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscaal
{
    internal class Inkomen : IInkomen
    {
        public InkomenType Soort { get; }
        public decimal Brutoloon { get; }
    }

    internal interface IInkomen
    {
        InkomenType Soort { get; }
        decimal Brutoloon { get; }
    }

    internal enum InkomenType
    {
        Loondienst = 0,
        WinstUitOnderneming = 1
    }
}
