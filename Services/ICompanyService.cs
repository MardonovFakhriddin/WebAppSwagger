using WebApi.Models;

namespace WebApi.Services;

public interface ICompanyService
{
    bool Create(Company company);
    List<Company> GetAll();
    bool Update(Company company);
    bool Delete(int id);
}