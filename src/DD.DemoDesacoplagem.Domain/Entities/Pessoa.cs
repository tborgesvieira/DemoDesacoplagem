﻿using System;
using System.Collections.Generic;

namespace DD.DemoDesacoplagem.Domain.Entities
{
    public class Pessoa
    {       
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }        
        public virtual PessoaFisica PessoaFisica { get; set; }
    }
}