using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Practica2.Pages
{   
    public class NominaModel : PageModel
    {  
        
        public string Nombres_empleado1 { get; set; } = "Alejandro Emmanuel";
        public string Apellidos_empleado1 { get; set; } = "Santos De los santos";
        public string cargo_empleado1 { get; set; } = "Soporte Junior";
        public string  salario_mensual_empleado1 { get; set; } = "40,000.00";
        public string Nombres_empleado2 { get; set; } = "Carlos Manuel";
        public string Apellidos_empleado2 { get; set; } = "Tejada ";
        public string cargo_empleado2 { get; set; } = "Soporte Senior";
        public string salario_mensual_empleado2 { get; set; } = "45,000.00";
        public string Nombres_empleado3 { get; set; } = "Carlos";
        public string Apellidos_empleado3 { get; set; } = "Rodriguez Then";
        public string cargo_empleado3 { get; set; } = "Soporte Senior";
        public string salario_mensual_empleado3 { get; set; } = "60,000.00";
        public string Nombres_empleado4 { get; set; } = "Victor Manuel";
        public string Apellidos_empleado4 { get; set; } = "Mendez Saba";
        public string cargo_empleado4 { get; set; } = "Soporte senior";
        public string salario_mensual_empleado4 { get; set; } = "65,000.00";
        public string Nombres_empleado5 { get; set; } = "Aguntin";
        public string Apellidos_empleado5 { get; set; } = "Reynoso Lara";
        public string cargo_empleado5 { get; set; } = "Soporte Junior";
        public string salario_mensual_empleado5 { get; set; } = "35,000.00";
        public string Nombres_empleado6 { get; set; } = "Michael";
        public string Apellidos_empleado6 { get; set; } = "Bernald";
        public string cargo_empleado6 { get; set; } = "Soporte Junior";
        public string salario_mensual_empleado6 { get; set; } = "85,000.00";

        public void OnGet()
        {
        }
    }
}
