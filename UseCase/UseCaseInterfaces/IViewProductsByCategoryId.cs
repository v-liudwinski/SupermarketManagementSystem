using CoreBusiness;
using System.Collections.Generic;

namespace UseCase
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);

    }
}