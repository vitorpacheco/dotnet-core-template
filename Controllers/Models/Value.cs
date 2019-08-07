using System;
using System.Runtime.Serialization;
using dotnet_core_template.Models;

namespace dotnet_core_template.Controllers.Models
{
    [DataContract]
    public class ValueRequest
    {
        [DataMember(Name = "titulo", IsRequired = true)]
        public string Titulo { get; set; }
    }
    
    [DataContract]
    public class ValueResponse
    {
        [DataMember(Name = "id")]
        public long Id;
        
        [DataMember(Name = "titulo")]
        public string Titulo;
        
        [DataMember(Name = "dataCriacao")]
        public DateTime DataCriacao;
        
        public ValueResponse(Value value)
        {
            this.Id = value.Id;
            this.Titulo = value.Titulo;
            this.DataCriacao = value.DataCriacao;
        }
    }
}