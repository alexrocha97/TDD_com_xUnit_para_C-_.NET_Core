using ExpectedObjects;
using test._Util;
using Xunit;

namespace test.Domain.Entidades
{
    public class Cursotest
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

        [Theory] // Usando o Theory no lugar de Fact
        [InlineData("")] // Aqui eu determino os parametros que quero executar, tanto vazio como nullo
        [InlineData(null)]
        public void Nao_Deve_Curso_Ter_Um_Nome_Invalido(string nomeInvalido)
        {
            // Organização
            var cursoEsperado = new 
                {
                    nome = "Curso de inglês", 
                    cargaHoraria = (double)19.00, 
                    publicoAlvo = PublicoAlvo.Estudante, 
                    valorCurso = (int)150
                };
            // Ação
            

            // Assert
            Assert.Throws<ArgumentException>(() => new Curso(
                    nomeInvalido, 
                    cursoEsperado.cargaHoraria, 
                    cursoEsperado.publicoAlvo, 
                    cursoEsperado.valorCurso
                )).ComMensagem("Nome inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void Nao_Deve_Curso_CargaHoraria_Menor_Que_Um(double cargaHorariaInvalida)
        {
            // Organização
            var cursoEsperado = new 
                {
                    nome = "Curso de inglês", 
                    cargaHoraria = (double)19.00, 
                    publicoAlvo = PublicoAlvo.Estudante, 
                    valorCurso = (int)150
                };
            // Ação
           

            // Assert
            Assert.Throws<ArgumentException>(() => new Curso(
                    cursoEsperado.nome, 
                    cargaHorariaInvalida, 
                    cursoEsperado.publicoAlvo, 
                    cursoEsperado.valorCurso
                )).ComMensagem("Carga Horaria inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void Nao_Deve_Curso_Um_Valor_Menor_Que_Um(int valorInvalido)
        {
            // Organização
            var cursoEsperado = new 
                {
                    nome = "Curso de inglês", 
                    cargaHoraria = (double)19.00, 
                    publicoAlvo = PublicoAlvo.Estudante, 
                    valorCurso = (int)150
                };
            // Ação

            // Assert
            Assert.Throws<ArgumentException>(() => new Curso(
                        cursoEsperado.nome, 
                        cursoEsperado.cargaHoraria, 
                        cursoEsperado.publicoAlvo, 
                        valorInvalido
                    )).ComMensagem("Valor inválido");
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

            ValidarCurso();
        }

        public string nome { get; private set; }
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

    public enum PublicoAlvo
    {
        Estudante,
        Universitario,
        Empregado,
        Empreendedor
    }
}
