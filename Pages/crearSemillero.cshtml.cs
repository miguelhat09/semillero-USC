using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp1.Data;

namespace WebApp1.Pages
{
    [Authorize]
    

    public class crearSemilleroModel : PageModel
    {
        private readonly ILogger<crearSemilleroModel> _logger;

       
       // public crearSemilleroModel(ILogger<crearSemilleroModel> logger)
        //{
          //  _logger = logger;
       // }

        private readonly ApplicationDbContext _db;
        public crearSemilleroModel(ApplicationDbContext db)
        {
            _db = db;
        }  

        [BindProperty]
        public  Semillero Semillero {get;set;}



        [TempData]
        public string Mensaje {get;set;}


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {

            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Add(Semillero);
            await _db.SaveChangesAsync();
            Mensaje = "Has creado un semillero de manera exitosa";
            return RedirectToPage("Index");

        }

    }
}
