using Facturations.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Dapper;

namespace Facturations.Server.Models
{
    public class BusinessDataRepository : IBusinessData, IDisposable
    {

        private MySqlConnection cnct;

        public BusinessDataRepository(string connectionString) 
        {
            cnct = new MySqlConnection(connectionString);
        }

        public IEnumerable<Facture> Factures =>
            cnct.Query<Facture>("SELECT * FROM factures");

        public decimal SalesRevenue => throw new NotImplementedException();

        public decimal Outstanding => throw new NotImplementedException();

        public void Dispose()
        {
            cnct.Dispose();
        }
    }
}
