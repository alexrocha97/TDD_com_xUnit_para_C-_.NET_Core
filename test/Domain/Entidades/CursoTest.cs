using Bogus;
using ExpectedObjects;
using src.Domain.Entidades;
using src.Enums;
using test._Builders;
using test._Util;
using Xunit;
using Xunit.Abstractions;

namespace test.Domain.Entidades
{
    // Critério de aceite 

    // Criar o curso com o nome, carga horária, publico alvo e valor
    // As opções do público alvo é estudante, universitário, empregada e empreendedor
    // Todos os campos do curso são obrigatórios
    // Curso deve ter uma descrição

    public class Cursotest : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly string _nome;
        private readonly double _cargaHoraria;
        private readonly PublicoAlvo _publicoAlvo;
        private readonly int _valorCurso;
        private readonly string _descricao;


        public void Dispose()
        {
            _output.WriteLine("Disposible sendo executado..");
        }
        public Cursotest(ITestOutputHelper output)
        {
            var faker = new Faker();
            _output = output;
            _output.WriteLine("Construtor sendo executado..");

            _nome = faker.Random.Word();
            _cargaHoraria = faker.Random.Double(50, 1000);
            _publicoAlvo = PublicoAlvo.Estudante;
            _valorCurso = faker.Random.Int(100, 1000);
            _descricao = faker.Lorem.Paragraph();
        }

        [Fact]
        public void Deve_Criar_Curso()
        {
            // Org
            var cursoEsperado = new 
            {
                nome = _nome, 
                descricao = _descricao,
                cargaHoraria = _cargaHoraria, 
                publicoAlvo = _publicoAlvo, 
                valorCurso = _valorCurso
            };

            // Ação
            var curso = new Curso
            (
                cursoEsperado.nome, 
                cursoEsperado.descricao,
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
            // var cursoEsperado = new 
            //     {
            //         nome = "Curso de inglês", 
            //         cargaHoraria = (double)19.00, 
            //         publicoAlvo = PublicoAlvo.Estudante, 
            //         valorCurso = (int)150
            //     };
            // Ação
            

            // Assert
            Assert.Throws<ArgumentException>(() => 
                CursoBuilder.Novo()
                .ComNome(nomeInvalido)
                .Build())
                .ComMensagem("Nome inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void Nao_Deve_Curso_CargaHoraria_Menor_Que_Um(double cargaHorariaInvalida)
        {
            // Organização
            // var cursoEsperado = new 
            //     {
            //         nome = "Curso de inglês", 
            //         cargaHoraria = (double)19.00, 
            //         publicoAlvo = PublicoAlvo.Estudante, 
            //         valorCurso = (int)150
            //     };
            // Ação
           

            // Assert
            Assert.Throws<ArgumentException>(() => 
                CursoBuilder.Novo()
                .ComCargaHoraria(cargaHorariaInvalida)
                .Build()).ComMensagem("Carga Horaria inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void Nao_Deve_Curso_Um_Valor_Menor_Que_Um(int valorInvalido)
        {
            // Organização
            // var cursoEsperado = new 
            //     {
            //         nome = "Curso de inglês", 
            //         cargaHoraria = (double)19.00, 
            //         publicoAlvo = PublicoAlvo.Estudante, 
            //         valorCurso = (int)150
            //     };
            // Ação

            // Assert
            Assert.Throws<ArgumentException>(() => 
                CursoBuilder.Novo()
                .ComValor(valorInvalido)
                .Build())
                .ComMensagem("Valor inválido");
        }
    }
}
