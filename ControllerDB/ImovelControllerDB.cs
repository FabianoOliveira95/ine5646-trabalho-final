using Microsoft.AspNetCore.Mvc;
using SuddenAmbiente.DataAccess;
using SuddenAmbiente.Models;
using SuddenAmbiente.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.ControllerDB
{
    public class ImovelControllerDB : IImovelRepository
    {
        private readonly SuddenDataContext _contexto;

        public ImovelControllerDB(SuddenDataContext ctx)
        {
            _contexto = ctx;
        }


        /// <summary>
        /// Procura todos os dados do produto.  
        /// </summary>
        public List<Imovel> GetAll()
        {
            List<Imovel> data = this._contexto.Imoveis.ToList();
            return data;
        }

        /// <summary>
        /// Insere uma Produto no banco da dados.  
        /// </summary>
        [HttpPost]
        public Imovel Add(Imovel model)
        {
            _contexto.Imoveis.Add(model);
            _contexto.SaveChanges();
            return model;

        }

        /// <summary>
        /// Atualiza um imóvel no banco da dados.  
        /// </summary>
        [HttpPost]
        public Imovel Update(Imovel model)
        {
            _contexto.Imoveis.Update(model);
            _contexto.SaveChanges();

            return model;
        }

        public Imovel Find(int id)
        {
            Imovel model = _contexto.Imoveis.FirstOrDefault(v => v.IdImovel == id);

            return model;
        }

        public Imovel GetByInscricao(string inscricao)
        {
            Imovel model = _contexto.Imoveis.FirstOrDefault(v => v.NumeroInscricao == inscricao);

            return model;
        }


        /// <summary>
        /// Procura todos os dados do produto.  
        /// </summary>
        public List<Imovel> FindAll()
        {
            List<Imovel> data = this._contexto.Imoveis.ToList();
            return data;
        }
    }
}
