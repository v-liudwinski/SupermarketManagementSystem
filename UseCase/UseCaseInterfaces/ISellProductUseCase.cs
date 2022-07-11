namespace UseCase
{
    public interface ISellProductUseCase
    {
        void Execute(string cshierName, int productId, int qtyToSell);
    }
}