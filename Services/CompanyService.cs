using WebApi.Models;

namespace WebApi.Services;

public class CompanyService: ICompanyService
{
    private List<Company> _companies = new List<Company>();
    public bool Create(Company company)
    {
        int cnt = 0;
        foreach (var a in _companies)
        {
            if (a.Id == company.Id)
            {
                cnt++;
                break;
            }
        }

        if (cnt == 1) return false;
        _companies.Add(company);
        return true;
    }

    public List<Company> GetAll() => _companies;
    

    public bool Update(Company company)
    {
        Company? company1 = _companies.FirstOrDefault(x => x.Id == company.Id);
        if (company1 == null) return false;
        int inx = _companies.BinarySearch(company1);
        _companies[inx].Name = company.Name;
        return true;
    }

    public bool Delete(int id)
    {
        Company? company1 = _companies.FirstOrDefault(x => x.Id == id);
        if (company1 == null) return false;
        _companies.Remove(company1);
        return true;
    }
}