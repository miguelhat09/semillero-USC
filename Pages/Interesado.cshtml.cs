using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Data;
using WebApp1.Model;

namespace WebApp1.Pages
{
    public class InteresadoModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public InteresadoModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Semillero Semillero {get;set;}

        [TempData]
        public string Mensaje {get;set;}
        public async Task OnGet(int id)
        {
            Semillero = await _db.Semillero.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var SemilleroDesdeDb = await _db.Semillero.FindAsync(Semillero.idSemillero);
                SemilleroDesdeDb.nombreSemillero = Semillero.nombreSemillero;
                SemilleroDesdeDb.descripcionSemillero = Semillero.descripcionSemillero;
                SemilleroDesdeDb.necesidadesSemillero = Semillero.necesidadesSemillero;
                SemilleroDesdeDb.interesadosSemillero = Semillero.interesadosSemillero;

                await _db.SaveChangesAsync();
                Mensaje = "Has aceptado el Semillero correctamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}