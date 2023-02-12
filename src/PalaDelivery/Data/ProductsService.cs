namespace PalaDelivery.Data
{
    public class ProductsService
    {
        private static readonly string[] ProductNames = new[]
        {
            "Pão de Queijo", "Pão de Mel", "Pão Doce", "Pão Francês"
        };

        public async Task<List<Product>> GetRandomProducts()
        {
            var random = new Random();

            var products = new List<Product>();

            foreach (var productName in ProductNames)
            {
                products.Add(new Product(productName, Math.Round(random.Next(5,10) + random.NextDouble(),2)));
            }

            var orderedProducts = products.OrderBy(p => p.Price).ToList();

            return await Task.FromResult(orderedProducts);
        }
    }
}
