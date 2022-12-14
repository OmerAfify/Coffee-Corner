using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.Interfaces.IGenericRepository;
using Domains.Models;

namespace Domains.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<Product> Products { get;  }
        public IGenericRepository<ProductBrand> ProductBrand { get;  }
        public IGenericRepository<Category> Categories { get;  }

        public Task Save();
    }
}
