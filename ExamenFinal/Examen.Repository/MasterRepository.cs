using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Repository;

namespace Examen.Repository
{
    //public abstract class MasterRepository
    public class MasterRepository
    {
        //private readonly ExamenContext _context;
        protected readonly ExamenContext _context;
        public MasterRepository()
        {
            if (_context == null)
            {
                _context = new ExamenContext();
            }
        }

        protected ExamenContext Context
        {
            get { return _context; }
        }

    }
}
