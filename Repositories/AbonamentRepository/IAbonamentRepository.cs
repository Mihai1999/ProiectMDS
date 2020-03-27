using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Models;

namespace Fitness.Repositories.AbonamentRepository
{
    public interface IAbonamentRepository
    {
        List<Abonament> GetAll();
        Abonament Get(int Id);
        Abonament Create(Abonament Abonament);
        Abonament Update(Abonament Abonament);
        Abonament Delete(Abonament Abonament);
    }
}
