using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prova.Model;

namespace Prova.Repository
{
    class PassagemRepository : BaseRepository
    {
        public void Salvar(Passagem passagem)
        {
            DataModel.Entry(passagem).State = passagem.id == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }

        public Passagem GetOne(string nome)
        {
            try
            {
                return DataModel.Passagem.First(e => e.nome_passageiro == nome || e.nome_passageiro.Contains(nome));
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public void Delete(Passagem passagem)
        {
            DataModel.Passagem.Remove(passagem);
            DataModel.SaveChanges();
        }
    }
}
