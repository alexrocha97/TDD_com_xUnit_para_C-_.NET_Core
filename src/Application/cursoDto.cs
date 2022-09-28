using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Application
{
    public class cursoDto
    {
        public cursoDto(string Nome, string Descricao,double CargaHoraria,int PublicoAlvoId, int Valor)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
            this.PublicoAlvoId = PublicoAlvoId;
            this.Valor = Valor;
        }
        public cursoDto()
        {}

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; set; }
        public int PublicoAlvoId { get; set; }
        public int Valor { get; set; }
    }
}
