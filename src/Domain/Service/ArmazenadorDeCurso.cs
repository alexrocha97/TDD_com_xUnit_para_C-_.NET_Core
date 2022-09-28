using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Application;
using src.Domain.Entidades;
using src.Domain.Interfaces;
using src.Enums;

namespace src.Domain.Service
{
    public class ArmazenadorDeCurso
    {
        public ArmazenadorDeCurso(ICursoRepository @object)
        {
            Object = @object;
        }

        public ICursoRepository Object { get; }

        public void Armazenar(cursoDto curso)
        {
            var cursoNovo = new Curso(curso.Nome,curso.Descricao,curso.CargaHoraria,PublicoAlvo.Estudante,curso.Valor);
        }
    }
    // {
    //     private readonly ICursoRepository _cursoRepository;
    //     public ArmazenadorDeCurso(ICursoRepository cursoRepository)
    //     {
    //         _cursoRepository = cursoRepository;
    //     }

    //     public void Armazenar(cursoDto curso)
    //     {
    //         var cursoNovo = new Curso(curso.Nome,curso.Descricao,curso.CargaHoraria,PublicoAlvo.Estudante,curso.Valor);
    //     }
}
