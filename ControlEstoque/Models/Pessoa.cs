﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Metadata.Conventions.Internal;

namespace ControlEstoque.Models
{
    public class Pessoa
    {
        [Key]
       
        public int PessoaId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
