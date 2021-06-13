namespace Cadastro_Empresas
{
    public class Empresas : Base
    {
        // Atributos
        public Empresas(int cnpj, string nome_Fantasia, int telefone, string email, string data, bool excluido)
        {
            this.Cnpj = cnpj;
            this.Nome_Fantasia = nome_Fantasia;
            this.Telefone = telefone;
            this.Email = email;
            this.Data = data;
            this.Excluido = excluido;

        }
        private int Cnpj { get; set; }
        private string Nome_Fantasia { get; set; }
        private int Telefone { get; set; }
        private string Email { get; set; }
        private string Data { get; set; }
        private bool Excluido { get; set; }
        // Métodos
        public Empresas(int id, int cnpj, string nome_fantasia, int telefone, string email, string data)
        {
            this.id = id;
            this.Cnpj = cnpj;
            this.Nome_Fantasia = nome_fantasia;
            this.Telefone = telefone;
            this.Email = email;
            this.Data = data;
            this.Excluido = false;
        }

            
        // Encapsulamento

        public int retornaCnpj()
        {
            return this.Cnpj;
        }

        public int retornaId()
        {
            return this.id;
        }

        public string retornaNome_Fantasia()
        {
            return this.Nome_Fantasia;
        }
        public int retornaTelefone()
        {
            return this.Telefone;
        }
        public string retornaData()
        {
            return this.Data;
        }
        public string retornaEmail()
        {
            return this.Email;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}