using Xunit;

namespace test._Util
{
    public static class AssertExtension
    {
        // Quando se usa o 'this' como parametro você está criando um método de extensão para a classe ArgumentException
        // Lembrando para criar um método de estensão a classe e o método tem que ser estaticos
        public static void ComMensagem(this ArgumentException exception, string msg)
        {
            if(exception.Message == msg)
                Assert.True(true);
            else
                Assert.False(true, $"Esperava a mensagem '{msg}'");                
        }
    }
}
