using Moq;
using src.Domain.Entidades;
using src.Enums;
using Xunit;

namespace test.Domain.Entidades
{
    public class ArmazenadorDeCursoTest
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            // Given
            var cursoDto = new cursoDto
            {
                Nome = "Curso A", 
                Descricao = "Descricao do curso",
                CargaHoraria = 80.0, 
                PublicoAlvoId = 1, 
                Valor = 120
            };
            // When
            var cursoRepositoryMoq = new Mock<ICursoRepository>();
            var AdicionarCurso = new ArmazenadorDeCurso(cursoRepositoryMoq.Object);
            AdicionarCurso.Armazenar(cursoDto);

            // Then
            cursoRepositoryMoq.Verify(x => x.Adicionar(It.IsAny<Curso>()));
        }
    }
    
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
    }

    public class ArmazenadorDeCurso
    {
        private readonly ICursoRepository cursoRepository;
        public ArmazenadorDeCurso(ICursoRepository _cursoRepository)
        {
            cursoRepository = _cursoRepository;
        }

        public void Armazenar(cursoDto curso)
        {
            var cursoNovo = new Curso(curso.Nome,curso.Descricao,curso.CargaHoraria,PublicoAlvo.Estudante,curso.Valor);
        }
    }

    public class cursoDto
    {
        public cursoDto()
        {
            
        }
        public cursoDto(string Nome, string Descricao,double CargaHoraria,int PublicoAlvoId, int Valor)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
            this.PublicoAlvoId = PublicoAlvoId;
            this.Valor = Valor;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; set; }
        public int PublicoAlvoId { get; set; }
        public int Valor { get; set; }
    }
}
