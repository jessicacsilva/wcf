using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf.Exemplo.Modelo;

namespace Wcf.Exemplo.Repositorio.Contexto
{
    public class CursoContexto:DbContext
    {
        public CursoContexto() : base("Cursos") { }

        public DbSet<Curso> Curso { get; set; }
    }
}
