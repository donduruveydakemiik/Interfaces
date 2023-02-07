using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.add(new SqlServerCostumerDal());
            Console.ReadLine(); 
        }
    }
}
