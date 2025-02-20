using Api_Filmes_Senai.Domains;
using Api_Filmes_Senai.Interfaces;

namespace Api_Filmes_Senai.Repositories
{

    /// <summary>
    /// Vai implementar a interfafce
    /// Ou seja, vamos implementar os metodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        private readonly Filmes_Context _context;
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }




        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }


        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }




        public List<Genero> Listar()
        {
            try
            {
                List<Genero> ListaGenero = _context.Genero.ToList();
                return ListaGenero;
            }
            catch (Exception)
            {

                throw;
            }
            }

            public void Cadastrar(Genero novoGenero)
            {
            try
            {
                _context.Genero.Add(novoGenero);

                _context.SaveChanges();



            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
