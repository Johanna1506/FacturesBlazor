using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturations.Shared
{
    public class BusinessData : IBusinessData
    {
        public List<Facture> listFactures;

        public BusinessData()
        {
             this.listFactures = new List<Facture>();
             this.Populate();
        }

        public void Populate()
        {
            Facture f1 = new Facture(1, "Johanna Corp", new DateTime(10 / 12 / 2020), new DateTime(13 / 12 / 2020), 120, 120);
            Facture f2 = new Facture(2, "Camille Corp", new DateTime(10 / 12 / 2020), new DateTime(13 / 12 / 2020), 120, 0);
            Facture f3 = new Facture(3, "Marco Corp", new DateTime(10 / 12 / 2020), new DateTime(13 / 12 / 2020), 120, 0);

            listFactures.Add(f1);
            listFactures.Add(f2);
            listFactures.Add(f3);
        }

        public IEnumerable<Facture> Factures => listFactures;

        public decimal SalesRevenue => listFactures.Sum(facture => facture.Amount);

        public decimal Outstanding => listFactures.Sum(facture => facture.Amount - facture.AmountPaid);
    }
}
