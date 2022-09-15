using Xunit;

namespace test
{
    public class MeuPrimeiroTest
    {
        [Fact(DisplayName = "Teste_de_variaveis")]
        public void Deve_ser_iguais_as_variaveis()
        {
            /// Organização:
            var num1 = 1;
            var num2 = 1;
            
            // Ação
            var soma = num1 + num2;
            var result = 2;

            /// Assert
            Assert.True(soma == result);
        }
    }
}
