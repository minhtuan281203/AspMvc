using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcKiemtra.Data;
using System;
using System.Linq;

namespace MvcKiemtra.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcKiemtraContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcKiemtraContext>>()))
        {
            // Look for any movies.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }
            context.Employee.AddRange(

new Employee
{
    EmployeeID = "EM001",
    EmployeeName = "John Carter",
    Department = "HR",
    Salary = 3000
},
                 new Employee
                 {
                     EmployeeID = "EM002",
                     EmployeeName = "Michael Bean",
                     Department = "SC",
                     Salary = 13000
                 },
                  new Employee
                  {
                      EmployeeID = "EM003",
                      EmployeeName = "Jimmy Floy",
                      Department = "MD",
                      Salary = 2000
                  },
                   new Employee
                   {
                       EmployeeID = "EM04",
                       EmployeeName = "Marry Brown",
                       Department = "MD",
                       Salary = 2000
                   }
            );
            context.SaveChanges();
        }
    }
}