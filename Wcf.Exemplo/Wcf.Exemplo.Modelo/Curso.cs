using System.Runtime.Serialization;

namespace Wcf.Exemplo.Modelo
{
    [DataContract]
    public class Curso
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NomeCurso { get; set; }

        [DataMember]
        public string Materia { get; set; }
    }
}