using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Data;
using WebApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        
         
        private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ApplicationDbContext _db;

        public IndexModel (ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Semillero> Semilleros {get;set;}

        public async Task OnGet()
        {
            Semilleros = await _db.Semillero.ToListAsync();
        }

        [TempData]
        public string Mensaje {get;set;}

    
        public async Task<IActionResult>OnPostDelete(int id)
        {
            var Semillero = await _db.Semillero.FindAsync(id);
            if(Semillero == null)
            {
                return NotFound();
            }

            _db.Semillero.Remove(Semillero);
            await _db.SaveChangesAsync();

            Mensaje = "Curso Borrado Correctamente";

            return RedirectToPage("Index");
        }
    }
}
