using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNetCore.Models
{

  [Table("TipoPermisos")]
    public class TipoPermiso
    {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoPermiso { get; set; } 

      
        public string Descripcion { get; set; }
        
    }
}
