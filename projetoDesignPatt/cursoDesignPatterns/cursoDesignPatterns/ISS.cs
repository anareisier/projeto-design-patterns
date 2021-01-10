using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoDesignPatterns
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)  // Com a implementação da interface substitiu-se calculaISS por Calcula 
        {
            return orcamento.Valor * 0.06;
        }
    }
}
