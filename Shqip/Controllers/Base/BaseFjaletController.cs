using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic;
using Model;
using Shqip.Data;
using Shqip.Models;

namespace Shqip.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BaseFjaletController<T> : ControllerBase
        where T : class, IFjale
    {
        private readonly ApplicationDbContext _context;

        public BaseFjaletController(ApplicationDbContext context)
        {
            _context = context;
        }


        public virtual IQueryable<T> Items
        {
            get
            {
                return _context.Set<T>().Where(i => i.KontribuesiID == User.Identity.Name);
            }
        }


        //[HttpGet("getpaged")]
        //public async Task<ResponseMessageResult> GetTPaged(string filter, int pageIndex, int pageSize, string sortOrder )
        //{
        //    var items = await Items.ToListAsync();

        //    HttpResponseMessage responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
        //    responseMessage.Headers.Add("MyHeader", "MyHeaderValue");
        //    responseMessage.Content = new StringContent("kfdgkjh");
        //    var response = new ResponseMessageResult(responseMessage);

        //    return response;
        //}



        [HttpGet("paged")]
        public virtual async Task<ActionResult<IEnumerable<T>>> GetTPaged(int pageIndex, int pageSize, string filter, string sortOrder)
        {
            if (pageIndex < 0) pageIndex = 0;
            if (pageSize < 5) pageSize = 5;
            if (pageSize > 20) pageSize = 20;

            var items = Items;
            if (!string.IsNullOrEmpty(filter))
            {
                items = items.Where(filter);
            }

            items = items.Skip(pageIndex * pageSize).Take(pageSize);

            if (!string.IsNullOrEmpty(sortOrder))
            {
                items = items.OrderBy(sortOrder);
            }


            Response.Headers.Add("TotalItems", Items.Count().ToString());

            var retList = await items.ToListAsync();
           
            return retList;
        }

        // GET: api/T
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetT()
        {
            return await Items.ToListAsync();
        }

        // GET: api/T/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetT(int id)
        {
            var t = await Items.FindAsync(id);

            if (t == null)
            {
                return NotFound();
            }

            return t;
        }

        // PUT: api/T/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT(int id, T t)
        {
            if (id != t.Id)
            {
                return BadRequest();
            }

            _context.Entry(t).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/T
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<T>> PostT(T t)
        {
            _context.Set<T>().Add(t);
            t.KontribuesiID = User.Identity.Name;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT", new { id = t.Id }, t);
        }

        // DELETE: api/T/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> DeleteT(int id)
        {
            var t = await Items.FindAsync(id);
            if (t == null)
            {
                return NotFound();
            }

            _context.Set<T>().Remove(t);
            await _context.SaveChangesAsync();

            return t;
        }

        private bool TExists(int id)
        {
            return Items.Any(e => e.Id == id);
        }
    }
}
