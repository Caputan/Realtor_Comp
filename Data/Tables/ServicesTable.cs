using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RieltorComp.Models;

namespace RieltorComp.Data.Tables
{
    public class ServicesTable
    {
        private readonly ApplicationContext _context;

        public ServicesTable(ApplicationContext context)
        {
            _context = context;
        }

        public List<Services> GetServices()
        {
            return _context.Services.ToList();
        }

        public Services GetService(string Service_Name)
        {
            return _context.Services.FirstOrDefault(u => u.Service_Name == Service_Name);
        }

        public void CreateService(Services service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
        }

        public void UpdateService(Services service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
        }

        public void UpdateServices(List<Services> services)
        {
            _context.Services.UpdateRange(services);
            _context.SaveChanges();
        }

        public void DeleteService(Services service)
        {
            _context.Services.Remove(service);
            _context.SaveChanges();
        }
    }
}