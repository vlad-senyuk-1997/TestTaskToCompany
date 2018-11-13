using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Store> Stores { get; }
        IRepository<Product> Products { get; }
        void Save();
    }
}
