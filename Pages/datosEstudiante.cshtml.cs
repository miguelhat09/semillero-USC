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
    public class datosEstudianteModel : PageModel
    {
        private readonly ILogger<datosEstudianteModel> _logger;

     //   public datosEstudianteModel(ILogger<datosEstudianteModel> logger)
       // {
         //   _logger = logger;
        //}

        private readonly ApplicationDbContext _db;

        public datosEstudianteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Estudiante Estudiante {get;set;}

        // AQUI VA LA TEMPDATA

        [TempData]
        public string Mensaje {get;set;}

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Add(Estudiante);
            await _db.SaveChangesAsync();
            Mensaje = "Has modificado tus datos de estudiante correctamente";
            return RedirectToPage("Index");
        }


        

        public void OnGet()
        {
            

        }
    }
}
