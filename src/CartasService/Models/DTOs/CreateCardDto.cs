using System;
using System.ComponentModel.DataAnnotations;

namespace CartasService.Models.DTOs;

public class CreateCardDto
{
    [Required]
    public int Id {get; set;}

    [Required]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    public string Pinta { get; set; } = string.Empty;

}
