using System.Collections.Generic;
using Cadastro_Empresas.interfaces;

namespace Cadastro_Empresas
{
    public class Empresas_Repositorio : IRepositorio<Empresas>
    {
        private List<Empresas> listaEmpresas = new List<Empresas>();
        public void Atualizar(int id, Empresas entidade)
        {
            listaEmpresas[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaEmpresas[id].Excluir();
        }

        public void Insere(Empresas entidade)
        {
            listaEmpresas.Add(entidade);
        }

        public List<Empresas> Lista()
        {
            return listaEmpresas;
        }

        public int ProximoId()
        {
            return listaEmpresas.Count;
        }

        public Empresas RetornoPorId(int id)
        {
            return listaEmpresas[id];
        }
    }
}