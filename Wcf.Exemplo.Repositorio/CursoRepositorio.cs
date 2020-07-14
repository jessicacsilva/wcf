using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf.Exemplo.Modelo;
using Wcf.Exemplo.Repositorio.Contexto;

namespace Wcf.Exemplo.Repositorio
{
    public class CursoRepositorio
    {
        public void InserirCurso(Curso curso)
        {
            CursoContexto context = new CursoContexto();

            context.Curso.Add(curso);
            context.SaveChanges();
        }


        public void AtualizarCurso(Curso curso)
        {
            CursoContexto context = new CursoContexto();

            context.Curso.Add(curso);
            context.SaveChanges();
        }


        public void ExcluirCurso(Curso curso)
        {
            CursoContexto context = new CursoContexto();

            context.Curso.Remove(curso);
            context.SaveChanges();
        }


        public List<Curso> ConsultaCurso()
        {
            CursoContexto context = new CursoContexto();

            return context.Curso.Select(c => c).ToList();            
        }
    }
}
