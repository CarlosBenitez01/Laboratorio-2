using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Dominio
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }

        public String NombrePersona { get; set; }

        public int EdadPersona { get; set; }

        public String DescripcionPersona { get; set; }

        //Con esto indico que hay una relacion entre course y entollment
    }
}
