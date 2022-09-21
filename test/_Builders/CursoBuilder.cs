using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Domain.Entidades;

namespace test._Builders
{
    public class CursoBuilder
    {
        private readonly string _nome;
        private readonly double _cargaHoraria;
        private readonly PublicoAlvo _publicoAlvo;
        private readonly int _valorCurso;
        private readonly string _descricao;

        public static CursoBuilder Novo()
        {
            return new CursoBuilder();
        }

        public Curso Build()
        {
            return new Curso(_nome,_descricao,_cargaHoraria,_publicoAlvo,_valorCurso);
        }
    }
}
