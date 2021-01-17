using System;

namespace Facturations.Shared
{
    public class Facture
    {
        private int _id;
        private string _name;
        private DateTime _billingDate;
        private DateTime _paymentDate;
        private int _amount;
        private int _amountPaid;



        public Facture(int Id, string Name, DateTime BillingDate, DateTime PaymentDate, int Amount, int AmountPaid)
        {
            this.Id = Id;
            this.Name = Name;
            this.BillingDate = BillingDate;
            this.PaymentDate = PaymentDate;
            this.Amount = Amount;
            this.AmountPaid = AmountPaid;

        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public DateTime BillingDate
        {
            get => _billingDate;
            set => _billingDate = value;
        }

        public DateTime PaymentDate
        {
            get => _paymentDate;
            set => _paymentDate = value;
        }

        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public int AmountPaid
        {
            get => _amountPaid;
            set => _amountPaid = value;
        }

        public bool IsPaid => Amount == AmountPaid;

        public bool IsLate => PaymentDate < DateTime.Now;

        public void RegisterPayment(DateTime when, int howMany)
        {
            if(when < BillingDate)
            {
                throw new ArgumentOutOfRangeException("Vous ne pouvez pas regler avant la creation de la facture");
            }
            PaymentDate = when;
            if(Amount-AmountPaid < howMany )
            {
                throw new ArgumentOutOfRangeException("Vous ne pouvez pas payer plus que la facture");
            }
            AmountPaid += howMany;
        }
    }
}
