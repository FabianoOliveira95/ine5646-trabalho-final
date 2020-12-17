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
    public class CorretorControllerDB : ICorretorRepository
    {
        private readonly SuddenDataContext _contexto;

        public CorretorControllerDB (SuddenDataContext ctx)
        {
            _contexto = ctx;
        }


        /// <summary>
        /// Procura todos os dados do produto.  
        /// </summary>
        public List<Corretor> GetAll()
        {
            List<Corretor> data = this._contexto.Corretores.ToList();
            return data;
        }

        /// <summary>
        /// Insere uma Produto no banco da dados.  
        /// </summary>
        [HttpPost]
        public Corretor Add(Corretor model)
        {
            _contexto.Corretores.Add(model);
            _contexto.SaveChanges();
            return model;

        }

        /// <summary>
        /// Atualizar uma Produto no banco da dados.  
        /// </summary>
        [HttpPost]
        public Corretor Update(Corretor model)
        {
            _contexto.Corretores.Update(model);
            _contexto.SaveChanges();

            return model;
        }

        public Corretor Find(int id)
        {
            Corretor model = _contexto.Corretores.FirstOrDefault(v => v.IdCorretor == id);

            return model;
        }

        public Corretor GetByName(string nome)
        {
            Corretor model = _contexto.Corretores.FirstOrDefault(v => v.Nome == nome);

            return model;
        }


        /// <summary>
        /// Procura todos os dados do produto.  
        /// </summary>
        public List<Corretor> FindAll()
        {
            List<Corretor> data = this._contexto.Corretores.ToList();
            return data;
        }
    }
}
