﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public BeneficiarioModel()
        {
            Itens = new List<BeneficiarioModel>();
        }

       
        public long Id { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Nome { get; set; }

        public string IdCliente { get; set; }

        public List<BeneficiarioModel> Itens { get; set; }
    }
}