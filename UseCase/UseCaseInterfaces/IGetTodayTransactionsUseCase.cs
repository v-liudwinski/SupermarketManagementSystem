using CoreBusiness;
using System.Collections.Generic;

namespace UseCase
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}