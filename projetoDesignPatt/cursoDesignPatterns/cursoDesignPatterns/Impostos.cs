using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoDesignPatterns
{
    public class Impostos
    {
        /* Código antes da criação de métodos e das classes para cada imposto:
         
        public void Calculo(Orcamento orcamento, String imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.15; - antes da classe ICMS
                Console.WriteLine(icms);
            } 
            
            else if ("ISS".Equals(imposto)) 
            {
                double iss = orcamento.Valor * 0.06; - antes da classe ISS 
                Console.WriteLine(iss);
            }

         */


        /*Criação de métodos para ações específicas, evita o uso dos "IF's" 
        
        public void CalculoICMS(Orcamento orcamento)
        {
            double icms = new ICMS().calculoICMS(orcamento);  // Delega cada regra de negócio para classes especializadas
            Console.WriteLine(icms);
        }

        public void CalculoISS(Orcamento orcamento)
        {
            double iss = new ISS().calculoISS(orcamento);   // Delega cada regra de negócio para classes especializadas
            Console.WriteLine(iss);
        }

        */

        //Após a implementação da interface Imposto o código fica mais limpo e mais acessível para possíveis alterações (STRATEGY)

        public void Calculo(Orcamento orcamento, Imposto imposto)
        {
            double I = imposto.Calcula(orcamento);
            Console.WriteLine(I);
        }

        

        
    
    }
}
