#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace conectionMysql.Models;
public class Mascota
{   
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }
    [Column("tiene_pelo")]
    public bool TienePelo { get; set; }
}
