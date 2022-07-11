using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCase
{
    public interface IGetTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}