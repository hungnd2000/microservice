using Basket.API.Entities;

namespace Basket.API.Application.Repositories
{
    public interface ICustomerBasketRepositories
    {
        Task<List<CustomerBasket>> GetAllCustomerBasketAsync();
        Task<CustomerBasket> GetCustomerBasketByIdAsync(int id);
        Task<CustomerBasket> AddCustomerBasketAsync(CustomerBasket basket);
        Task<CustomerBasket> UpdateCustomerBasketAsync(CustomerBasket basket);
        Task<bool> DeleteCustomerBasketAsync(int id);
    }
}
