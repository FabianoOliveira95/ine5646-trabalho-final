using SuddenAmbiente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Repository
{
    public interface IInteresseRepository
    {
        List<Interesse> GetAll();

        Interesse Add(Interesse interesse);

        Interesse Find(int id);

        List<Interesse> FindAll();
    }
}
