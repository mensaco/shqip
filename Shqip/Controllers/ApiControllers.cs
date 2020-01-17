using Microsoft.EntityFrameworkCore;
using Model;
using Shqip.Data;
using System.Linq;

namespace Shqip.Controllers
{
    public class EmratController : BaseFjaletController<Emer>
    {

        private ApplicationDbContext _context;
        public EmratController(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public override IQueryable<Emer> Items
        {
            get
            {
                return base.Items
                    .Include(r => r.RasatNjejesPashquar)
                    .Include(r => r.RasatShumesPashquar)
                    .Include(r => r.RasatNjejesShquar)
                    .Include(r => r.RasatShumesShquar);
            }
        }
    }

}
