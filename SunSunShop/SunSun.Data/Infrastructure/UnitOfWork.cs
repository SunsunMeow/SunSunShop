using SunSun.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SunSun.Data.Infrastructure
{
    public class UnitOfWork : IDisposable
    {
        private SunSunDbContext context = new SunSunDbContext();
        private GenericRepository<Shipper> shipperRepository;
        private GenericRepository<Account> accountRepository;
        private GenericRepository<Order> orderRepository;
        private GenericRepository<Customer> customerRepository;
        
        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Customer>(context);
                }
                return customerRepository;
            }
        }
        public GenericRepository<Shipper> ShipperRepository
        {
            get 
            {
                if (this.shipperRepository == null)
                {
                    this.shipperRepository = new GenericRepository<Shipper>(context);
                }
                return shipperRepository; 
            }
        }
        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (this.orderRepository == null)
                {
                    this.orderRepository = new GenericRepository<Order>(context);
                }
                return orderRepository;
            }
        }
        public GenericRepository<Account> AccountRepository
        {
            get
            {
                if (this.accountRepository == null)
                {
                    this.accountRepository = new GenericRepository<Account>(context);
                }
                return accountRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        #region Disposable
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
