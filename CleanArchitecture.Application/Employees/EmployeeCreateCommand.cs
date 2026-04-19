using CleanArchitecture.Domain.Employees;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Result;
using Mapster;
using GenericRepository;
using FluentValidation;

namespace CleanArchitecture.Application.Employees
{
    public sealed record EmployeeCreateCommand(string FirstName,
        string LastName,
        string BirthOfDate,
        string Email,
        decimal Salary,
        PersonelInformation PersonelInformation, Address? Address) : IRequest<Result<string>>;


    public sealed class EmployeeCreateCommandValidator : AbstractValidator<EmployeeCreateCommand>
    {
        public EmployeeCreateCommandValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(e => e.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(e => e.BirthOfDate).NotEmpty().WithMessage("Birth of date is required.");
            RuleFor(e => e.Email).NotEmpty().EmailAddress().WithMessage("A valid email is required.");
            RuleFor(e => e.Salary).GreaterThan(0).WithMessage("Salary must be greater than zero.");
            RuleFor(e => e.PersonelInformation.TCNo).MinimumLength(11).MaximumLength(11).WithMessage("Personel information is required.");
        }
    }
    public sealed class EmployeeCreateCommandHandler(IEmployeeRepository employeeRepository,IUnitOfWork unitOfWork) : IRequestHandler<EmployeeCreateCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(EmployeeCreateCommand request, CancellationToken cancellationToken)
        {
            var isEmployeeExists = await employeeRepository.AnyAsync(e => e.PersonelInformation.TCNo == request.PersonelInformation.TCNo, cancellationToken);

            if (isEmployeeExists)
            {
                return Result<string>.Failure(400, $"Employee with TCNo {request.PersonelInformation.TCNo} already exists.");
            }
            
            
            Employee employee=request.Adapt<Employee>();

            employeeRepository.Add(employee);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return Result<string>.Succeed(employee.Id.ToString());
        }
    }
}
