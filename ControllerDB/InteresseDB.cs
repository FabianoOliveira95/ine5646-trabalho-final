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
    public class InteresseDB : IInteresseRepository
    {
        private readonly SuddenDataContext _contexto;

        public InteresseDB(SuddenDataContext ctx)
        {
            _contexto = ctx;
        }


        /// <summary>
        /// Procura todos os dados do interesse.  
        /// </summary>
        public List<Interesse> GetAll()
        {
            List<Interesse> data = this._contexto.Interesses.ToList();
            return data;
        }

        /// <summary>
        /// Insere um interesse no banco da dados.  
        /// </summary>
        [HttpPost]
        public Interesse Add(Interesse model)
        {
            _contexto.Interesses.Add(model);
            _contexto.SaveChanges();
            return model;

        }

        /// <summary>
        /// Atualiza um interesse no banco da dados.  
        /// </summary>
        [HttpPost]
        public Interesse Update(Interesse model)
        {
            _contexto.Interesses.Update(model);
            _contexto.SaveChanges();

            return model;
        }

        public Interesse Find(int id)
        {
            Interesse model = _contexto.Interesses.FirstOrDefault(v => v.IdInteresse == id);

            return model;
        }


        /// <summary>
        /// Procura todos os interessados em imóveis 
        /// </summary>
        public List<Interesse> FindAll()
        {
            List<Interesse> data = this._contexto.Interesses.ToList();
            return data;
        }
    }
}
