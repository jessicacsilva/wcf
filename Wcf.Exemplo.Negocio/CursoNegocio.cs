using System;
using System.Collections.Generic;
using Wcf.Exemplo.Modelo;
using Wcf.Exemplo.Repositorio;


namespace Wcf.Exemplo.Negocio
{
    public class CursoNegocio:IDisposable
    {
        private readonly IDisposable _dispose;

        public void InserirCurso(Curso curso)
        {
            var repo = new CursoRepositorio();

            repo.InserirCurso(curso);
        }

        public void ExcluirCurso(Curso curso)
        {
            var repo = new CursoRepositorio();

            repo.ExcluirCurso(curso);
        }

        public void AtualizarCurso(Curso curso)
        {
            var repo = new CursoRepositorio();

            repo.AtualizarCurso(curso);
        }

        public List<Curso> ConsultaCurso()
        {
            var repo = new CursoRepositorio();

            return repo.ConsultaCurso();
        }

        public void Dispose()
        {
            _dispose?.Dispose();
        }
    }
}
