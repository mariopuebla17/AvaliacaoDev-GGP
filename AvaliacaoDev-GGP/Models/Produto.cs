using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AvaliacaoDev_GGP.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string Desc { get; set; }
        [Required]
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Required]
        [Display(Name = "Quantidade")]
        public int Qtd { get; set; }
    }
}