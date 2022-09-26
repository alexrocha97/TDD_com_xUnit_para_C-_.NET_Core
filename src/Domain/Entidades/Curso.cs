using src.Enums;

namespace src.Domain.Entidades
{
    public class Curso
    {
        public Curso(
            string nome, 
            string descricao,
            double cargaHoraria, 
            PublicoAlvo publicoAlvo, 
            int valorCurso)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.cargaHoraria = cargaHoraria;
            this.publicoAlvo = publicoAlvo;
            this.valorCurso = valorCurso;

            ValidarCurso();
        }

        public string nome { get; private set; }
        public string descricao { get; set; }
        public double cargaHoraria { get; private set; }
        public PublicoAlvo publicoAlvo { get; private set; }
        public int valorCurso { get; private set; }


        public void ValidarCurso()
        {
            if(String.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome inválido");
            else if(cargaHoraria < 1)
                throw new ArgumentException("Carga Horaria inválido");
            else if(valorCurso < 1)
                throw new ArgumentException("Valor inválido");
        }
    }
}
