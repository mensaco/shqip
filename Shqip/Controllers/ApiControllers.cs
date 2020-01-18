using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic;
using Model;
using Shqip.Data;

namespace Shqip.Controllers
{
    public class EmratController : BaseFjaletController<Emer>
    {

        public EmratController(ApplicationDbContext context) : base(context)
        {
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



        [HttpGet("paged")]
        public override async Task<ActionResult<IEnumerable<Emer>>> GetTPaged(int pageIndex, int pageSize, string filter, string sortOrder)
        {
            if (pageIndex < 0) pageIndex = 0;
            if (pageSize < 5) pageSize = 5;
            if (pageSize > 20) pageSize = 20;

            var items = Items;
            if (!string.IsNullOrEmpty(filter))
            {
                items = items.Where(i => i.Antonimet.Contains(filter) ||
                i.KontribuesiID.Contains(filter) ||
                i.NjejesiPashquar.Contains(filter) ||
                i.ShumesiPashquar.Contains(filter) ||
                i.NjejesiShquar.Contains(filter) ||
                i.ShumesiShquar.Contains(filter) ||
                i.Pershkrimet.Contains(filter) ||
                i.Sinonimet.Contains(filter) ||
                i.TeNgjashme.Contains(filter) ||
                i.Antonimet.Contains(filter));
            }

            items = items.Skip(pageIndex * pageSize).Take(pageSize);

            if (!string.IsNullOrEmpty(sortOrder))
            {
                items = items.OrderBy(sortOrder);
            }

            if (!Response.Headers.ContainsKey("TotalItems"))
            {
                Response.Headers.Add("TotalItems", Items.Count().ToString());
            }
            Response.Headers["TotalItems"] = Items.Count().ToString();
            var retList = await items.ToListAsync();

            return retList;
        }
    }

}
