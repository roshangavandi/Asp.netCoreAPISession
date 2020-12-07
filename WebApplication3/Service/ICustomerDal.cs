using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Service
{
    public interface ICustomerDal
    {
        string Guid { get; set; }
        void Add();
        void Update();
    }
}
