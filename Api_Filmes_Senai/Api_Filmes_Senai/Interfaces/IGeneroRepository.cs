using System.Runtime.InteropServices.ObjectiveC;
using Api_Filmes_Senai.Domains;

namespace Api_Filmes_Senai.Interfaces {
    ///<summary>
    /// Interface para Genero : Contrato
    /// Toda classe que herdar essa interface,  
    /// todos os metodos definidos aqui dentro devera implementar
    ///</summary>

    ///Crude : Metodos 
    ///C : Create : Cadastrar um novo objeto
    ///R : Read listar todos os objetos
    ///U : Update alterar um objeto
    ///D : Delete deleto o ou excluo um objeto 


    ///Metodo = TipoDeRetorno NomeDoMetodo(Argumentos ou Parametros)

    public interface IGeneroRepository
    {   

        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();
        void Atualizar(Guid id, Genero genero);

        void Deletar(Guid id);

        Genero BuscarPorId(Guid id);

    

    }
}
