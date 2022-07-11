using CoreBusiness;
using System.Collections.Generic;

namespace UseCase
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}