using DataAccessObject.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObject.DAO
{
    public class AnuncioDAO
    {
        public static List<Anuncio> LerTodos()
        {
            using var context = new DataContext();
            return context.Anuncios.ToList();
        }

        public static Anuncio LerAnuncio(int id)
        {
            using var context = new DataContext();
            return context.Anuncios.Where(s => s.ID == id).FirstOrDefault();
        }

        public static bool InserirAnuncio(Anuncio anuncio)
        {
            try
            {
                using (var context = new DataContext())
                {
                    context.Add(anuncio);
                    context.SaveChanges();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool AtualizarAnuncio(Anuncio anuncio)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var entity = context.Anuncios.First(s => s.ID == anuncio.ID);
                    entity.marca = anuncio.marca;
                    entity.modelo = anuncio.modelo;
                    entity.versao = anuncio.versao;
                    entity.ano = anuncio.ano;
                    entity.quilometragem = anuncio.quilometragem;
                    entity.observacao = anuncio.observacao;
                    context.SaveChanges();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Erro: " + ex.Message); ;
                return false;
            }
        }

        public static bool DeletarAnuncio(int id)
        {
            try
            {
                using var context = new DataContext();
                Anuncio service = context.Anuncios.Single(s => s.ID == id);
                context.Anuncios.Remove(service);
                context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
