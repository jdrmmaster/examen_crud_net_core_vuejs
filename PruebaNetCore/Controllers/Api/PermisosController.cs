using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNetCore.Models;

namespace PruebaNetCore.Controllers
{
   
    public class PermisosController : Controller
    {
        private DbContextProyect contx;
        private PermisoRepository permisoRepository;
        public PermisosController(DbContextProyect context)
        {
            this.contx = context;
        }
        [HttpGet]
        [Route("/permisos")]
        public IActionResult Get()
        {
            permisoRepository = new PermisoRepository(contx);
            

            List<Permiso> permiso = permisoRepository.getAll();
            return Ok(permiso);
        }

        [HttpPost]
        [Route("/update")]
        public IActionResult Post(Permiso permiso)
        {
            //permisoRepository = new PermisoRepository(contx);
            permisoRepository = new PermisoRepository(contx);
            Permiso p =  permisoRepository.update(permiso);
            //List<Permiso> lpermiso = permisoRepository.getAll();
            return Ok(p);
        }


        [HttpPut]
        [Route("/create")]
        public IActionResult Create(Permiso permiso)
        {
            //permisoRepository = new PermisoRepository(contx);
            permisoRepository = new PermisoRepository(contx);
            Permiso p = permisoRepository.create(permiso);
           // List<Permiso> lpermiso = permisoRepository.getAll();
            return Ok(p);
        }

        [HttpPut]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            //permisoRepository = new PermisoRepository(contx);
            permisoRepository = new PermisoRepository(contx);
            Permiso p = permisoRepository.delete(id);
            // List<Permiso> lpermiso = permisoRepository.getAll();
            return Ok(p);
        }

        [HttpGet]
        [Route("/getTipo")]
        public IActionResult getTipo()
        { 
            permisoRepository = new PermisoRepository(contx); 
             
            return Ok(permisoRepository.getTipoAll());
        }
    }
    
}
