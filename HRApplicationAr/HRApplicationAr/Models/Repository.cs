using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplicationAr.Models
{
    public class Repository
    {
        private static List<Employee> employeeList = new List<Employee>();
        public static IEnumerable<Employee> GetEmployees()
        {
                 return employeeList;
        }
        public static void addEMP(Employee employee)
        {
            employeeList.Add(employee);
        }
    }
}
