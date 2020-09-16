using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_MetodosAbstratos.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
                               :base (nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoImposto()
        {
            double tx;

            if(RendaAnual <= 20000 && GastosSaude > 0)
            {
                tx = (RendaAnual * 0.25)- (GastosSaude * 0.50) ;
            }else
            {
                tx = (RendaAnual * 0.15) - (GastosSaude * 0.50);
            }

            return tx;
        }
    }
}
