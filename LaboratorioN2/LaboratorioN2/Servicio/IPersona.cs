using LaboratorioN2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Servicio
{
    public interface IPersona
    {
        void Save(Persona p);

        ICollection<Persona> ListarDatos();
    }
}
