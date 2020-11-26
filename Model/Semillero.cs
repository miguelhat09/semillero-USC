using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Model{
    public class Semillero
    {
        [Key]
        public int idSemillero {get; set;}

        [Required(ErrorMessage = "Debes escribir algo minimo, 3 letras ")]
        [MinLength(3)]
        [MaxLength(75)]
        [Display(Name = "Nombre del semillero")]
        public string nombreSemillero  {get; set;}
        [Required(ErrorMessage = "Debes escribir algo minimo, 12 letras ")]
        [MinLength(12)]
        [MaxLength(250)]
        [Display(Name = "Descripcion semillero")]
        public string descripcionSemillero {get; set;}
        [Required(ErrorMessage = "Debes escribir algo minimo, 12 letras ")]
        [MinLength(12)]
        [MaxLength(250)]
        [Display(Name = "Necesidades semillero")]
        public string necesidadesSemillero {get; set;}
        
        public string interesadosSemillero {get; set;}

        

    }
}