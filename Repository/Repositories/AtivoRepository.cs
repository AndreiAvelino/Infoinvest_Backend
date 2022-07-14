using Domain.Ativo;
using Repository.Data;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class AtivoRepository : IAtivoRepository
    {
        private ApplicationDbContext _context;

        public AtivoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(AtivoDAO ativo)
        {
            _context.Ativo.Remove(ativo);
            _context.SaveChanges();
        }

        public AtivoDAO Get(Guid id)
        {
            return _context.Ativo.Find(id);
        }

        public IEnumerable<AtivoDAO> GetAll()
        {
            return _context.Ativo.ToList();
        }

        public void Insert(AtivoDAO ativo)
        {
            _context.Ativo.Add(ativo);
            _context.SaveChanges();
        }

        public void Update(AtivoDAO ativo)
        {
            _context.Ativo.Update(ativo);
            _context.SaveChanges();
        }
    }
}
