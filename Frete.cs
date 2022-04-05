using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreteApp02
{
    public class Frete
    {
        public int Cep { get; set; }
        public double Peso { get; set; }
		public int Estado{ get; set; }

        private ICorreioService correioService;

        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
        }

        public double CalcularFrete()
        {
            public double AdicionalFrete()
			{
				switch (correioService.Estado) {
					case 1:
						return correioService.CalculaFrete() + 5;
					case 2:
						return correioService.CalculaFrete() + 8;
					case 3:
						return correioService.CalculaFrete() + 7;
					default:
						return correioService.CalculaFrete();
				}
			}
        }
    }
}
