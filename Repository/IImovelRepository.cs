using SuddenAmbiente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Repository
{
    public interface IImovelRepository
    {
        List<Imovel> GetAll();

        Imovel Add(Imovel imovel);

        Imovel Update(Imovel imovel);

        public Imovel GetByInscricao(string inscricao);

        Imovel Find(int id);

        List<Imovel> FindAll();
    }
}
