using System;

namespace Cadastro_Empresas
{
    class Program
    {
        static Empresas_Repositorio repositorio = new Empresas_Repositorio();
        static void Main(string[] args)
        {
             string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    ListarEmpresas();
                    break;
                    case "2":
                    InserirEmpresas();
                    break;
                    case "3":
                    AtualizarEmpresas();
                    break;
                    case "4":
                   ExcluirEmpresas();
                    break;
                    case "5":
                    VisualizarEmpresas();
                    break;
                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static void ListarEmpresas()
        {
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma empresa cadastrada. ");
                return;
            }

            foreach (var empresas in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", empresas.retornaId(), empresas.retornaNome_Fantasia());
            }
        }

        private static void InserirEmpresas()
        {
            Console.WriteLine("Inserir nova empresa: ");
            
            Console.Write("Digite Nome Fantasia da Empresa: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Informe o CNPJ: ");
            int entradacnpj = int.parse(Console.ReadLine());

            Console.Write("Digite o Telefone: ");
            int entradatelefone = int.parse(Console.ReadLine());

            Console.Write("Informe o E-mail da empresa: ");
            String entradaemail = Console.ReadLine();

            string entradadata = DateTime.Now.ToString("dd-mm-yyyy");

            Empresas novaEmpresa = new Empresas(id: repositorio.ProximoId(), 
                                            nome_fantasia: entradaNome, cnpj: entradacnpj, telefone: entradatelefone,
                                            email: entradaemail, data: entradadata);

            repositorio.Insere(novaEmpresa);                                

        }

         private static void AtualizarEmpresas()
        {
          Console.WriteLine("Atualize os Dados da Empresa: ");
          Console.Write("Digite o ID da Empresa que você quer atualizar: ");
          int indiceEmpresa = int.Parse(Console.ReadLine());

          Console.Write("Digite Nome Fantasia da Empresa: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Informe o CNPJ: ");
            int entradacnpj = int.parse(Console.ReadLine());

            Console.Write("Digite o Telefone: ");
            int entradatelefone = int.parse(Console.ReadLine());

            Console.Write("Informe o E-mail da empresa: ");
            String entradaemail = Console.ReadLine();
            string entradadata = DateTime.Now.ToString("dd-mm-yyyy");

            Empresas atualizarEmpresas = new Empresas(id: indiceEmpresa, 
                                            nome_fantasia: entradaNome, cnpj: entradacnpj, telefone: entradatelefone,
                                            email: entradaemail, data: entradadata);

            repositorio.Atualizar(indiceEmpresa, atualizarEmpresas);   

        }

           private static void ExcluirEmpresas()
        {
            Console.Write("Digite o ID da Empresa a ser excluída: ");
            int indiceEmpresa = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceEmpresa);
        }

         private static void VisualizarEmpresas()
        {
            Console.Write("Digite o ID da empresa: ");
            int indiceEmpresa = int.Parse(Console.ReadLine());

            var empresa = repositorio.RetornoPorId(indiceEmpresa);
            Console.WriteLine(empresa);
        }
           private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("---------------- Cadastro de Empresas ----------------");
            Console.WriteLine("Seja Bem-Vindo!");
            Console.WriteLine("Escolha a opção desejada: ");

            Console.WriteLine("1- Listar Empresas: ");
            Console.WriteLine("2- Cadastrar uma nova Empresa: ");
            Console.WriteLine("3- Atualizar Dados de uma Empresa: ");
            Console.WriteLine("4- Excluir Empresa ");
            Console.WriteLine("5- Visualizar Empresa: ");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
