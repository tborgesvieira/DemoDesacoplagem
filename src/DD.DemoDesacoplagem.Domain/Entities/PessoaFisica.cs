using System;

namespace DD.DemoDesacoplagem.Domain.Entities
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Cpf { get; set; }        
        public int Pessoa { get; set; }                
        public virtual Pessoa FkPessoa { get; set; }        
        public Guid Usuario { get; set; }        
    }
}