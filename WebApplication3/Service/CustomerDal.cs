using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Service
{
    public class CustomerDal : ICustomerDal
    {
        //public string Guid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Guid { get; set; }

        public CustomerDal()
        {
            this.Guid = System.Guid.NewGuid().ToString();
        }
        public void Add()
        {
            Console.Write("demoo");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
