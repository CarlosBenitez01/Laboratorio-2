using LaboratorioN2.Data;
using LaboratorioN2.Dominio;
using LaboratorioN2.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Repository
{
    public class PersonaRepository : IPersona
    {
        private ApplicationDbContext app;

        public PersonaRepository(ApplicationDbContext app)
        {
            this.app = app;
        }

        public void Save(Persona p)
        {
            app.Update(p);
            app.SaveChanges();
        }
        
        public ICollection<Persona> ListarDatos()
        {
            return app.Persona.ToList();
        }
    }
}
