using Bogus;
using Moq;
using src.Application;
using src.Domain.Entidades;
using src.Domain.Interfaces;
using src.Domain.Service;
using Xunit;

namespace test.Domain.Entidades
{
    public class ArmazenadorDeCursoTest
    {
        private cursoDto _cursoDto;
        public ArmazenadorDeCursoTest()
        {
            var faker = new Faker();
            _cursoDto = new cursoDto
            {
              Nome = faker.Random.Words(),
              Descricao = faker.Lorem.Paragraph(),
              CargaHoraria = faker.Random.Double(),
              PublicoAlvoId = 1,
              Valor = faker.Random.Int()
            };
        }

        [Fact]
        public void DeveAdicionarCurso()
        {
            
            // Given
            var cursoRepositoryMoq = new Mock<ICursoRepository>();
            var AdicionarCurso = new ArmazenadorDeCurso(cursoRepositoryMoq.Object);
            // When
            AdicionarCurso.Armazenar(_cursoDto);

            // Then
            cursoRepositoryMoq.Verify(x => 
                x.Armazenar((It.Is<Curso>(r 
                    => r.Nome == _cursoDto.Nome &&
                        r.Descricao == _cursoDto.Descricao
                    )
                )
            ));
        }
    }
}
