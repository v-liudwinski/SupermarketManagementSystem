namespace UseCase
{
    public interface IRecordTransactionUseCase
    {
        void Execute(string cashierName, int productId,  string productName, int qty);
    }
}