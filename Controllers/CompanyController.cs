using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace DefaultNamespace;

[ApiController]
[Route("api/[controller]")]
public class CompanyController : ControllerBase
{
    private CompanyService companyService = new();
    [HttpGet("/get-all")]
    public List<Company> GetAll()=>companyService.GetAll();
    
    [HttpPost("/create-company")]
    public bool Create(Company company)=>companyService.Create(company);

    [HttpPut("/update-company")]
    public bool Update(Company company) => companyService.Update(company);

    [HttpDelete("/delete-company")]
    public bool Delete(int id) => companyService.Delete(id);
}