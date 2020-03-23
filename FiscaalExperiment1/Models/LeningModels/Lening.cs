using System;
using System.Collections.Generic;
using System.Text;

namespace FiscaalExperiment1.Models.LeningModels
{
    internal class Lening : ILening
    {
        public Lening(decimal hoofdsom, decimal nominaleRente, DateTime startdatum, int looptijdInMnd, LeningType soort)
        {
            Hoofdsom = hoofdsom;
            NominaleRente = nominaleRente;
            Startdatum = startdatum;
            LooptijdInMnd = looptijdInMnd;
            Soort = soort;
        }
        public decimal Hoofdsom { get; }
        public decimal NominaleRente { get; }
        public DateTime Startdatum { get; }
        public int LooptijdInMnd { get; }
        public LeningType Soort { get; }

        public override string ToString()
        {
            return string.Format("Hoofdsom: {0}, nominale rente: {1}, startdatum: {2}, looptijd: {3}, soort lening: {4}",
                Hoofdsom, NominaleRente, Startdatum, LooptijdInMnd, Soort);
        }
    }

    internal interface ILening
    {
        decimal Hoofdsom { get; }
        decimal NominaleRente { get; }
        DateTime Startdatum { get; }
        int LooptijdInMnd { get; }
        LeningType Soort { get; }
    }

    public enum LeningType
    {
        Lineair = 0,
        Annuitair = 1,
        Aflossingsvrij = 2
    }
}
