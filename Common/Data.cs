using DataAccessObject.DAO;
using DataAccessObject.Models;
using System.Collections.Generic;

namespace Common
{
    public class Data
    {
        public static List<Anuncio> ObterTodosAnuncios() => AnuncioDAO.LerTodos();
        public static Anuncio ObterAnuncioEspecifico(int id) => AnuncioDAO.LerAnuncio(id);
        public static bool AtualizarAnuncio(Anuncio anuncio) => AnuncioDAO.AtualizarAnuncio(anuncio);
        public static bool InserirAnuncio(Anuncio anuncio) => AnuncioDAO.InserirAnuncio(anuncio);
        public static bool DeletarAnuncio(int id) => AnuncioDAO.DeletarAnuncio(id);
    }
}
