using PodeVotar;

namespace PodeVotarTest
{
    public class PodeVotarTest
    {
            [Fact]
            public void NaoPodeVotar()
            {
                // Arrange
                int idade = 11;
                string esperado = "Não pode votar!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }

            [Fact]
            public void VotoOpcionalJovem()
            {
                // Arrange
                int idade = 16;
                string esperado = "Voto opcional!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }

            [Fact]
            public void PodeVotar()
            {
                // Arrange
                int idade = 18;
                string esperado = "Voto obrigatório!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }

            [Fact]
            public void VotoOpcionalIdoso()
            {
                // Arrange
                int idade = 79;
                string esperado = "Voto opcional!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }
        
    }
}