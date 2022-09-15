using ExpectedObjects;
using Xunit;

namespace test.Domain.Entidades
{
    public class CursoTest
    {
        [Fact]
        public void Deve_Criar_Curso()
        {
            // Org
            var cursoEsperado = new 
            {
                nome = "Curso de inglês", 
                cargaHoraria = (double)19.00, 
                publicoAlvo = PublicoAlvo.Estudante, 
                valorCurso = (int)150
            };

            // Ação
            var curso = new Curso
            (
                cursoEsperado.nome, 
                cursoEsperado.cargaHoraria, 
                cursoEsperado.publicoAlvo, 
                cursoEsperado.valorCurso
            );
            
            // Assert
            // Nesse caso ele está analisando se o curso esperado usando a ferramenta ExpectedObject deve corresponder ao curso criado
            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }
    }


    public class Curso
    {
        public Curso(
            string nome, 
            double cargaHoraria, 
            PublicoAlvo publicoAlvo, 
            int valorCurso)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.publicoAlvo = publicoAlvo;
            this.valorCurso = valorCurso;
        }

        public string nome { get; private set; }
        public double cargaHoraria { get; private set; }
        public PublicoAlvo publicoAlvo { get; private set; }
        public int valorCurso { get; private set; }
    }

    public enum PublicoAlvo
    {
        Estudante,
        Universitario,
        Empregado,
        Empreendedor
    }
}
