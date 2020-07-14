using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf.Exemplo.Modelo;

namespace Wcf.Exemplo
{
    [ServiceContract]
    public interface ICursoServico
    {

        [OperationContract]
        List<Curso> ConsultarCursos();

        [OperationContract]
        void InserirCurso(Curso curso);

        [OperationContract]
        void ExcluirCurso(Curso curso);

        [OperationContract]
        void AtulizaCurso(Curso curso);
    }
}
