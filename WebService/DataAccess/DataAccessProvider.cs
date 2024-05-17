using System.Collections.Generic;
using System.Linq;
using WebService.Models;

namespace WebService.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly MySQLContext _context;

        public DataAccessProvider(MySQLContext context)
        {
            _context = context;
        }

        public List<Catalumnocs> GetAlumnos()
        {
            return _context.Catalumnocs.ToList();
        }
    }
}

