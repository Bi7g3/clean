using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Employees
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
    }
}
