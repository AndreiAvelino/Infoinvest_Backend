using Domain.Carteira;
using Repository.Data;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CarteiraRepository : ICarteiraRepository
    {
        private ApplicationDbContext _context;

        public CarteiraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(CarteiraDAO carteira)
        {
            _context.Carteira.Remove(carteira);
            _context.SaveChanges();
        }

        public CarteiraDAO Get(Guid id)
        {
            return _context.Carteira.Find(id);
        }

        public IEnumerable<CarteiraDAO> GetAll()
        {
            return _context.Carteira.ToList();
        }

        public void Insert(CarteiraDAO carteira)
        {
            _context.Carteira.Add(carteira);
            _context.SaveChanges();
        }

        public void Update(CarteiraDAO carteira)
        {
            _context.Carteira.Update(carteira);
            _context.SaveChanges();
        }

        public IEnumerable<CarteiraDAO> GetAllPerUser(Guid id)
        {
            return _context.Carteira.Where(c => c.UsuarioId == id).ToList();
        }
    }
}
