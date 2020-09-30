using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNetCore.Models
{
    public interface IPermiso
    {

        Permiso getById(int id);
        List<TipoPermiso> getTipoAll();
        List<Permiso> getAll(); 
        Permiso create(Permiso permiso);

        Permiso update(Permiso permiso);

        Permiso delete(int id);
    }
}
