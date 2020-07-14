using System.Collections.Generic;
using Wcf.Exemplo.Modelo;
using Wcf.Exemplo.Negocio;

namespace Wcf.Exemplo
{
    public class CursoServico : ICursoServico
    {
        public void AtulizaCurso(Curso curso)
        {
            using (var negorio = new CursoNegocio())
            {
                negorio.AtualizarCurso(curso);
            }
        }

        public List<Curso> ConsultarCursos()
        {
            using (var negorio = new CursoNegocio())
            {
                return negorio.ConsultaCurso();
            }
        }

        public void InserirCurso(Curso curso)
        {
            using (var negorio = new CursoNegocio())
            {
                negorio.InserirCurso(curso);
            }
        }

        public void ExcluirCurso(Curso curso)
        {
            using (var negorio = new CursoNegocio())
            {
                negorio.ExcluirCurso(curso);
            }
        }
    }
}
