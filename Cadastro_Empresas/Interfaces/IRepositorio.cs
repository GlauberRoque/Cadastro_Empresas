using System.Collections.Generic;

namespace Cadastro_Empresas.interfaces
{
    
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornoPorId(int id);
         void Insere(T entidade);
         void Excluir(int id);
         void Atualizar(int id, T entidade);
        int ProximoId();
    }
}