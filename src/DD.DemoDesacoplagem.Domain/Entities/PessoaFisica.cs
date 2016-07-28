namespace DD.DemoDesacoplagem.Domain.Entities
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        //Coluna Pessoa na tabela PessoaFisica é uma composição para Pessoa
        public int Pessoa { get; set; }        
        //EPessoa - Entidade Pessoa
        public virtual Pessoa EPessoa { get; set; }
        //Coluna Usuario na tabela PessoaFisica é uma composição para Usuario - AspNetUsers
        public string Usuario { get; set; }
        public virtual Usuario EUsuario { get; set; }
    }
}