using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RieltorComp.Models;

namespace RieltorComp.Data.Tables
{
    public class PropertiesTable
    {
        private readonly ApplicationContext _context;

        public PropertiesTable(ApplicationContext context)
        {
            _context = context;
        }

        public List<Properties> GetProperties()
        {
            return _context.Properties.ToList();
        }

        public Properties GetProperty(string Adress)
        {
            return _context.Properties.FirstOrDefault(u => u.Address == Adress);
        }

        public Properties GetPropertyById(int id)
        {
            return _context.Properties.FirstOrDefault(u => u.Id == id);
        }

        public void CreateProperty(Properties property)
        {
            _context.Properties.Add(property);
            _context.SaveChanges();
        }

        public void UpdateProperty(Properties property)
        {
            _context.Properties.Update(property);
            _context.SaveChanges();
        }

        public void UpdateProperties(List<Properties> properties)
        {
            _context.Properties.UpdateRange(properties);
            _context.SaveChanges();
        }

        public void DeleteProperty(Properties property)
        {
            _context.Properties.Remove(property);
            _context.SaveChanges();
        }
    }
}