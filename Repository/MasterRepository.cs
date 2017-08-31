using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public abstract class MasterRepository
    {
        private readonly SystemContext _context;

        
        protected MasterRepository()
        {
            if (_context == null)
            {
                _context = new SystemContext();
            }
        }

        protected SystemContext Context
        {
            get { return _context; }
        }
    }
    
}
