using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.Core
{
    public class Leilao
    {
        private IList<Lance> _lances;
        public IEnumerable<Lance> Lances => _lances;
        public string Peca { get; }
        public Lance Ganhador { get; private set; }

        public Leilao(string peca)
        {
            Peca = peca;
            _lances = new List<Lance>();
        }

        public void RecebeLance(Interessada cliente, double valor)
        {
            _lances.Add(new Lance(cliente, valor));
        }

        public void IniciaPregao()
        {

        }

        public void TerminaPregao()
        {

            Ganhador = Lances
                .DefaultIfEmpty(new Lance(null, 0))
                .OrderBy(l => l.Valor)
                .LastOrDefault();
            //.LastOrDefault(); verifica se há um valor para último, se não lança o default setado;
            //.DefaultIfEmpty(new Lance(null, 0), se não tiver lance, cria um lance null com o valor 0
        }
    }
}
