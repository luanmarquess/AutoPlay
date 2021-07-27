using Xunit;
using Alura.LeilaoOnline.Core;
using System.Text;
using System.Linq;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeOferta
    {
        [Fact]
        public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimoLance()
        {
            //Arranje - Recebe lances porém com o leilao já finalizado;
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Porshe", modalidade);
            var fulano = new Interessada("Fulano", leilao);


            leilao.IniciaPregao();
            leilao.RecebeLance(fulano, 800);


            // Act - método sob test
            leilao.RecebeLance(fulano, 1000);

            //Assert
            var qtdaEsperada = 1;
            var qtdaObtida = leilao.Lances.Count();
            Assert.Equal(qtdaEsperada, qtdaObtida);
        }

        [Theory]
        [InlineData(4, new double[] { 1000, 1200, 1400, 1300 })]// primeiro teste com 4 valores
        [InlineData(2, new double[] { 800, 900})] // segundo teste com 2 valores
        public void NaoPermiteNovosLancesDadoLeilaoFinalizado( int qtdaEsperada, double[] ofertas) 
        {
            //Arranje - Recebe lances porém com o leilao já finalizado;
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Porshe", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.IniciaPregao();

            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i%2)==0)//for par
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }

            leilao.TerminaPregao();

            // Act - método sob test
            leilao.RecebeLance(fulano, 100);

            //Assert
            var qtdaObtida = leilao.Lances.Count();
            Assert.Equal(qtdaEsperada, qtdaObtida);
        }
    }
}
