using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNetCore.Models
{
    public class PermisoRepository : IPermiso
    {
        private readonly DbContextProyect context;
        private List<Permiso> permisoList;

        public PermisoRepository(DbContextProyect context)
        {
            this.context = context;
        }
        public Permiso create(Permiso permiso)
        {

             permiso.TipoPermiso = null;
             DateTime d = DateTime.Now; 
             permiso.FechaPermiso = d;
             context.Permisos.Add(permiso);
             context.SaveChanges();
             return permiso;
           // throw new NotImplementedException();
        }

        public Permiso delete(int id)
        {
             Permiso permiso = context.Permisos.Find(id);
            if(permiso != null)
            {
                 context.Permisos.Remove(permiso);
                context.SaveChanges();  
            }
            return permiso;
            //throw new NotImplementedException();
        }

        public List<Permiso> getAll()
        {
             
            permisoList = new List<Permiso>();
 
             /*var listPers = context.Permisos.FromSqlRaw("select " +
                 " p.IdPermiso," + 
                 " p.NombreEmpleado," +
                 " p.ApellidoEmpleado," +
                 " p.FechaPermiso," +
                 " p.TipoPermiso," + 
                 " tp.IdTipoPermiso," +
                 " tp.Descripcion as Desctipo " +
                 " from Permisos p" +
                 " left join TipoPermisos tp on tp.IdTipoPermiso =  p.TipoPermiso ").ToList(); */

       
            return context.Permisos.Include("TipoPermiso").ToList();
          
        }

        public Permiso getById(int id)
        {
            return context.Permisos.Find(id);

            //throw new NotImplementedException();
        }

         

        public List<TipoPermiso> getTipoAll()
        {
            return context.TipoPermisos.ToList();
            //throw new NotImplementedException();
        }

        public Permiso update(Permiso permiso)
        {
            /*  var tempPermiso = context.Permisos.Attach(permiso);
              tempPermiso.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
              context.SaveChanges();*/
               

             
            var p = context.Permisos.Find(permiso.IdPermiso);
                p.NombreEmpleado = permiso.NombreEmpleado;
                p.ApellidoEmpleado = permiso.ApellidoEmpleado;
               // p.FechaPermiso = permiso.FechaPermiso;
                p.IdTipoPermiso = permiso.IdTipoPermiso;
            p.TipoPermiso = null;
            
            context.SaveChanges(); 
           
           

            return permiso;
            // throw new NotImplementedException();
        }

         
    }
}
