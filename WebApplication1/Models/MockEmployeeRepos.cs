using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockEmployeeRepos : IEmployeeRepos
    {
        private List<Employee> _Employlist;

            public MockEmployeeRepos()
        {
            _Employlist = new List<Employee>();
            Employee Employee1 = new Employee();
            Employee1.id = 1;
            Employee1.name = "narayan";
            Employee1.dept = "IT";
            Employee1.email = "narayanbankegmail.com";
            _Employlist.Add(Employee1);
            Employee Employee2 = new Employee();
            Employee2.id = 2;
            Employee2.name = "supriya";
            Employee2.dept = "IT";
            Employee2.email = "supriyagmail.com";
            _Employlist.Add(Employee2);
        }

        public Employee getEmployee(int id)
        {
           return _Employlist.FirstOrDefault(e => e.id == id);
        }
    }
}
