using Domain.ClassificacaoAtivo;
using Repository.Data;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClassificacaoAtivoRepository : IClassificacaoAtivoRepository
    {
        private ApplicationDbContext _context;

        public ClassificacaoAtivoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(ClassificacaoAtivoDAO classificacao)
        {
            _context.ClassificacaoAtivo.Remove(classificacao);
            _context.SaveChanges();
        }

        public ClassificacaoAtivoDAO Get(Guid id)
        {
            return _context.ClassificacaoAtivo.Find(id);
        }

        public IEnumerable<ClassificacaoAtivoDAO> GetAll()
        {
            return _context.ClassificacaoAtivo.ToList();
        }

        public void Insert(ClassificacaoAtivoDAO classificacao)
        {
            _context.ClassificacaoAtivo.Add(classificacao);
            _context.SaveChanges();
        }

        public void Update(ClassificacaoAtivoDAO classificacao)
        {
            _context.ClassificacaoAtivo.Update(classificacao);
            _context.SaveChanges();
        }
    }
}
