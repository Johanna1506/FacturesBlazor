using System;
using System.Collections.Generic;

namespace Facturations.Shared
{
    public interface IbusinessData
    {

        IEnumerable<Facture> Factures { get; }
    }
}
