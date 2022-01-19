using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroProduto.Api.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

       public List<Departamento> Departamento { get; set; }

        public decimal Preco { get; set; }

        public bool Status { get; set; }

        public bool Deletado { get; set; }
    }
}
