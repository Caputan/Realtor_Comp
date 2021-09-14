using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RieltorComp.Models;

namespace RieltorComp.Data.Tables
{
    public class ContractsTable
    {
        private readonly ApplicationContext _context;

        public ContractsTable(ApplicationContext context)
        {
            _context = context;
        }

        public List<Contracts> GetContracts()
        {
            return _context.Contracts.ToList();
        }

        public Contracts GetContract(string propertyAdress)
        {
            return _context.Contracts.FirstOrDefault(u => u.Property.Address == propertyAdress);
        }

        public void CreateContract(Contracts contract)
        {
            _context.Contracts.Add(contract);
            _context.SaveChanges();
        }

        public void UpdateContract(Contracts contract)
        {
            _context.Contracts.Update(contract);
            _context.SaveChanges();
        }

        public void UpdateContracts(List<Contracts> contracts)
        {
            _context.Contracts.UpdateRange(contracts);
            _context.SaveChanges();
        }

        public void DeleteContract(Contracts contract)
        {
            _context.Contracts.Remove(contract);
            _context.SaveChanges();
        }
    }
}