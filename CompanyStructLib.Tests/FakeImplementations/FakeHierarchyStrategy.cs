using CompanyStructLib.Interfaces;
using CompanyStructLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyStructLib.Tests.FakeImplementations
{
    class FakeHierarchyStrategy : IHierarchyStrategy
    {
        public IEnumerable<Employee> GetHierarchy(IEnumerable<Employee> employees)
        {
            return new List<Employee>();
        }
    }
}
