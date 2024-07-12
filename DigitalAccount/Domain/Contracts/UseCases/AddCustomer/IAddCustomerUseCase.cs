using Domain.Entities;

namespace Domain.Contracts.UseCases.AddCustomer;

public interface IAddCustomerUseCase
{
    void AddCustoemr(Customer customer);
}