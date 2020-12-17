using SuddenAmbiente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Repository
{
    public interface ICorretorRepository
    {
        List<Corretor> GetAll();

        Corretor GetByName(string nome);

        public Corretor Update(Corretor model);

        Corretor Add(Corretor corretor);

        Corretor Find(int id);

        List<Corretor> FindAll();
    }
}
