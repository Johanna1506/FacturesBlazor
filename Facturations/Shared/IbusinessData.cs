using System;
using System.Collections.Generic;

namespace Facturations.Shared
{
    public interface IBusinessData
    {

        IEnumerable<Facture> Factures { get; }

        decimal SalesRevenue { get; }

        decimal Outstanding { get; }
    }

}
