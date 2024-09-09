
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using MauiApp1.Models;

namespace MauiApp1.Data
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Get all products
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("/products");
        }

        // Get a single product by ID
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"/products/{id}");
        }

        // Add a new product
        public async Task<Product> AddProductAsync(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync("/products", product);
            return await response.Content.ReadFromJsonAsync<Product>();
        }

        // Update a product
        public async Task UpdateProductAsync(int id, Product product)
        {
            await _httpClient.PutAsJsonAsync($"/products/{id}", product);
        }

        // Delete a product
        public async Task DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"/products/{id}");
        }

    }
}
