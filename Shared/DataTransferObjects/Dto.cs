namespace Shared.DataTransferObjects;

public record CompanyDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string FullAddress { get; set; }


}

public record EmployeeDto(Guid Id,string Name,int Age,string Position);

public record CompanyForCreateDto
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Country { get; set; }

}