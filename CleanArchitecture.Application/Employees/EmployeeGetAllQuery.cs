using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Employees;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Employees
{
    public class EmployeeGetAllQuery : IRequest<IQueryable<EmployeeGetAllQueryResponse>>
    {

    }

    public class EmployeeGetAllQueryResponse:EntityDto
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateOnly BirthOfDate { get; set; }
        public decimal Salary { get; set; }

        public string TCNo { get; set; } = default!;
        
    }

    public sealed class EmployeeGetAllQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<EmployeeGetAllQuery,
        IQueryable<EmployeeGetAllQueryResponse>>
{
        public async Task<IQueryable<EmployeeGetAllQueryResponse>> Handle(EmployeeGetAllQuery request, CancellationToken cancellationToken)
        {
            var response =employeeRepository.GetAll()
                .Select(x => new EmployeeGetAllQueryResponse
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthOfDate = x.BirthOfDate,
                    Salary = x.Salary,
                    Id = x.Id,
                    CreatedAt = x.CreatedAt,
                    IsActive = true,
                    UpdatedAt = x.UpdatedAt,
                    TCNo = x.PersonelInformation.TCNo

                }).AsQueryable();
            return response;
        }
    }
}
