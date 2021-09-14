using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RieltorComp.Models;

namespace RieltorComp.Data.Tables
{
    public class ClientsTable
    {
        private readonly ApplicationContext _context;

        public ClientsTable(ApplicationContext context)
        {
            _context = context;
        }

        public List<Clients> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Clients GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(u => u.Id == id);
        }

        public Clients GetClient(string FIO)
        {
            return _context.Clients.FirstOrDefault(u => u.FIO == FIO);
        }

        public Clients GetClientByPassport(string passport)
        {
            return _context.Clients.FirstOrDefault(u => u.Passport == passport);
        }

        public void CreateClient(Clients client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClient(Clients client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void UpdateClients(List<Clients> clients)
        {
            _context.Clients.UpdateRange(clients);
            _context.SaveChanges();
        }

        public void DeleteClient(Clients client)
        {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }

    }
}