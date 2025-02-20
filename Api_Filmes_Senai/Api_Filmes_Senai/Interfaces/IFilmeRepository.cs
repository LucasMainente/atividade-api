using Api_Filmes_Senai.Domains;

namespace Api_Filmes_Senai.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme NovoFilme);

        List<Filme> Listar();

        void Atualizar(Guid id, Filme filme);

        void Deletar(Guid id);

        void BuscarPorId(Guid id);

    }
}
