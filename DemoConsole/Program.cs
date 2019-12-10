using CompanyStructLib.Implementations;
using CompanyStructLib.Models;
using System;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director("Joe Johns", 50000);

            SaleManager saleManager = new SaleManager("Stive Stivenson", 18000);
            SaleWorker workerX = new WorkerX("David Blum", 6600);
            saleManager.AddSubordinate(workerX);

            DeliveryManager deliveryManager = new DeliveryManager("Eshly Bims", 20000);
            DeliveryWorker workerA = new WorkerA("Mat Fil", 6000);
            DeliveryWorker workerB = new WorkerB("Erik Ovel", 5500);
            deliveryManager.AddSubordinate(workerA);
            deliveryManager.AddSubordinate(workerB);
            var visitor = new SubordinateVisitor();

            director.AddSubordinate(saleManager);
            director.AddSubordinate(deliveryManager);
            director.AcceptVisitor(visitor);

            Company company = new Company();            
            company.SetHierarchyStrategy(new PositionalHierarchyStrategy());
            company.AddEmployee(workerA);
            company.AddEmployee(saleManager);
            company.AddEmployee(workerX);
            company.AddEmployee(deliveryManager);
            company.AddEmployee(workerB);
            company.AddEmployee(director);
            company.GetByWage(120);
            var res = company.GetStructure();
            
            foreach (var r in visitor.Get())
            {
                Console.WriteLine($"{r.Position}\n");
            }
        }
    }
}
