using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_core_template.Models
{
    
    [Table("values")]
    public class Value
    {
        [Column("id")]
        [Required]
        [Key]
        public long Id { get; set; }
        
        [Column("titulo")]
        [Required]
        public string Titulo { get; set; }
        
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; }
        
        public Value()
        {
            if (this.DataCriacao == null) {
                this.DataCriacao = DateTime.Now;
            }
        }
    }
}