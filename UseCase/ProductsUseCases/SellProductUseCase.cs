using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.DataStorePluginsInterfaces;

namespace UseCase
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(
            IProductRepository productRepository,
            IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }

        public void Execute(string cashierName, int productId, int qtyToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;
            recordTransactionUseCase.Execute(cashierName, productId, product.Name, qtyToSell);

            product.Quantity -= qtyToSell;
            productRepository.UpdateProduct(product);
        }

    }
}
