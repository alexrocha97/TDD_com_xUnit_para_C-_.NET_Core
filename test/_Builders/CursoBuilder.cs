using src.Domain.Entidades;
using src.Enums;

namespace test._Builders
{
    public class CursoBuilder
    {
        private string _nome = "Curso de inglês";
        private double _cargaHoraria = 19.00;
        private PublicoAlvo _publicoAlvo = PublicoAlvo.Estudante;
        private int _valorCurso = 150;
        private string _descricao = "Uma descrição";

        public static CursoBuilder Novo()
        {
            return new CursoBuilder();
        }

        public CursoBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public CursoBuilder ComDescricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }

        public CursoBuilder ComCargaHoraria(double cargahoraria)
        {
            _cargaHoraria = cargahoraria;
            return this;
        }

        public CursoBuilder ComValor(int cursovalor)
        {
            _valorCurso = cursovalor;
            return this;
        }

        public CursoBuilder ComPublico(PublicoAlvo publicoAlvo)
        {
            _publicoAlvo = publicoAlvo;
            return this;
        }

        public Curso Build()
        {
            return new Curso(_nome,_descricao,_cargaHoraria,_publicoAlvo,_valorCurso);
        }
    }
}
