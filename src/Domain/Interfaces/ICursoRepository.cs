using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Domain.Entidades;

namespace src.Domain.Interfaces
{
    public interface ICursoRepository
    {
        void Armazenar(Curso curso);
    }
}
