using CoreBusiness;

namespace UseCase
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}