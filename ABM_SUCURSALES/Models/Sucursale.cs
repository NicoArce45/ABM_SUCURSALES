using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABM_SUCURSALES.Models;

public partial class Sucursale
{
   
    public int IdSucursales { get; set; }
    [Required(ErrorMessage = "El campo Nombre es obligatorio")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "El campo Direccion es obligatorio")]
    public string? Direccion { get; set; }
    [Required(ErrorMessage = "El campo telefono es obligatorio")]
    public int? Telefono { get; set; }
}
