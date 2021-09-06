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
        public List<EmpleadoModel> Empleados { get; set; }

        public void OnGet()
        {
            Empleados = new List<EmpleadoModel>();

            Empleados.Add(new EmpleadoModel
            {
                Nombres_empleado = "Alejandro Emmanuel",
                Apellidos_empleado = "Santos De los santos",
                Cargo_empleado = "Soporte Junior",
                Salario_mensual_empleado = "40,000.00",
            });

            Empleados.Add(new EmpleadoModel
            {
                Nombres_empleado = "Carlos Manuel",
                Apellidos_empleado = "Tejada ",
                Cargo_empleado = "Soporte Senior",
                Salario_mensual_empleado = "45,000.00",
            });

            Empleados.Add(new EmpleadoModel
            {
                Nombres_empleado = "Carlos",
                Apellidos_empleado = "Rodriguez Then",
                Cargo_empleado = "Soporte Senior",
                Salario_mensual_empleado = "60,000.00",
            });

            Empleados.Add(new EmpleadoModel
            {
                Nombres_empleado = "Victor Manuel",
                Apellidos_empleado = "Mendez Saba",
                Cargo_empleado = "Soporte senior",
                Salario_mensual_empleado = "65,000.00",
            });

            Empleados.Add(new EmpleadoModel
            {
                Nombres_empleado = "Aguntin",
                Apellidos_empleado = "Reynoso Lara",
                Cargo_empleado = "Soporte Junior",
                Salario_mensual_empleado = "35,000.00",
            });

            Empleados.Add(new EmpleadoModel
            {
                Nombres_empleado = "Michael",
                Apellidos_empleado = "Bernald",
                Cargo_empleado = "Soporte Junior",
                Salario_mensual_empleado = "85,000.00",
            });
        }
    }

    public class EmpleadoModel
    {
        public string Nombres_empleado { get; set; }
        public string Apellidos_empleado { get; set; }
        public string Cargo_empleado { get; set; }
        public string Salario_mensual_empleado { get; set; }
    }
}
