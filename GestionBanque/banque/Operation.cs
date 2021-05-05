using System;

namespace GestionBanque.banque
{
    class Operation
    {
        private decimal montant;
        private DateTime date;
        private Sens sens;
        private string description;

        public Operation(decimal montant, string description, Sens sens)
        {
            Montant = montant;
            Date = DateTime.Now;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Sens = sens;
        }

        public decimal Montant { get => montant; set => montant = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        internal Sens Sens { get => sens; set => sens = value; }

        public override string ToString() => $"{date} : {sens}, {montant}€.";

    }

    enum Sens
    {
        Credit,
        Debit
    }
}