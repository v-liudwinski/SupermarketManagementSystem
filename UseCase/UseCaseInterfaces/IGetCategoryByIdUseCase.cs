using CoreBusiness;

namespace UseCase
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}