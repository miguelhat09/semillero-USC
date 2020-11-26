using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebApp1.Model{
    public class Estudiante
    {
        [Key]
        public int idEstudiante {get; set;}

        [Required(ErrorMessage = "Debes escribir algo minimo, 3 letras ")]
        [MinLength(3)]
        [MaxLength(75)]
        [Display(Name = "Nombre completo Estudiante")]
        public string nombreEstudiante {get; set;}

        [Required(ErrorMessage = "Debes escribir algo minimo, 3 letras ")]
        [MinLength(3)]
        [MaxLength(250)]
        [Display(Name = "Carrera estudiante")]
        public string carreraEstudiante {get; set;}

        [Required(ErrorMessage = "Debes escribir algo minimo, 1  ")]
        
        
        [Display(Name = "Semestre")]
        public int semestreEstudiante {get; set;}
        
       
        [Required(ErrorMessage = "Debes escribir algo minimo, 1  ")]
        
        
        [Display(Name = "Numero")]
        public int numeroEstudiante {get; set;}
        

        [Required(ErrorMessage = "Debes escribir algo minimo, 1  ")]
        
        
        [Display(Name = "cedula")]
        public int cedulaEstudiante {get; set;}


        [Required(ErrorMessage = "Debes escribir algo minimo, 1  ")]
        [MinLength(1)]
        [MaxLength(25)]
        [Display(Name = "Correo estudiante")]
        public string correoEstudiante {get; set;}

        
       

    }
}