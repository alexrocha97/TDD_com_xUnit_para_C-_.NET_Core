using src.Enums;

namespace src.Domain.Entidades
{
    public class Curso
    {
        public Curso(
            string Nome, 
            string Descricao,
            double CargaHoraria, 
            PublicoAlvo PublicoAlvo, 
            int ValorCurso)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
            this.PublicoAlvo = PublicoAlvo;
            this.ValorCurso = ValorCurso;

            ValidarCurso();
        }

        public string Nome { get; private set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public int ValorCurso { get; private set; }


        public void ValidarCurso()
        {
            if(String.IsNullOrEmpty(Nome))
                throw new ArgumentException("Nome inválido");
            else if(CargaHoraria < 1)
                throw new ArgumentException("Carga Horaria inválido");
            else if(ValorCurso < 1)
                throw new ArgumentException("Valor inválido");
        }
    }
}
