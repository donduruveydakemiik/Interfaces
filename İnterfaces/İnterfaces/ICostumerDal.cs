using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal interface ICostumerDal //veri tabanı işlemlerini yapmak için kullanıyoruz
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCostumerDal : ICostumerDal
    {
        public void Add()
        {
           Console.WriteLine("sql added.");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("sql updateded.");
        }

    }

    class OracleCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("oracle updateded.");
        }

    }

    class CustomerManager
    {
        public void add(ICostumerDal customerDal)
        {
            customerDal.Add();
            
        }
    }

}
