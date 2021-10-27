﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Haleji.BusinessObjects;

namespace Haleji.RepositoryBase
{
    public interface IPurchaseRepository : IGenericRepository<Purchase>
    {
        List<Purchase> GetByTransactionType(long transType);

        List<Purchase> GetByPurchaseId(long id);

        /*public void UpdatePurchaseDetails(Purchase entity);*/
    }
}
