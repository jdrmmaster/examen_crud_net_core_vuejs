using Microsoft.AspNetCore.Mvc;
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNetCore.Models
{
  
    
    [Table("Permisos")]
    public class Permiso
    {
        [Key] 
        public int IdPermiso { get; set; }

        
        public int IdTipoPermiso { get; set; }

 
        public string NombreEmpleado { get; set; }

     
       
        public string ApellidoEmpleado { get; set; }

      
        public DateTime FechaPermiso  { get; set; }

         
        [ForeignKey("IdTipoPermiso")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual TipoPermiso TipoPermiso { get; set; }

       
       

    }
}
