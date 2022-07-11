using CoreBusiness;
using System.Collections.Generic;

namespace UseCase
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}