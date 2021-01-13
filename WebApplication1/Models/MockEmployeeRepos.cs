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
            Employee Employee3 = new Employee();
            Employee3.id = 3;
            Employee3.name = "banke";
            Employee3.dept = "IT";
            Employee3.email = "bankegmail.com";
            _Employlist.Add(Employee3);


        }

        public Employee getEmployee(int id)
        {
            Employee emptemp = null;

            foreach (Employee emp in _Employlist)
            {
                if (emp.id == id)
                {
                    emptemp = emp;
                    break;                        
                 }
            }
            //return _Employlist.FirstOrDefault(emp => emp.id == id);
            return emptemp;
        }
    }
}
