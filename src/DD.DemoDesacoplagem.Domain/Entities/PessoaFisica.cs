using System;
using System.Collections.Generic;

namespace DD.DemoDesacoplagem.Domain.Entities
{
    public class PessoaFisica
    {        
        public int Id { get; set; }
        public string Cpf { get; set; }                          
        public virtual Pessoa Pessoa { get; set; }
        public Guid Usuario { get; set; }        
    }
}