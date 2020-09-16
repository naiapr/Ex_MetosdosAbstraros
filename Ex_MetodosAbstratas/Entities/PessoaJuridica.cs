using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_MetodosAbstratos.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        protected PessoaJuridica(string nome, double rendaAnual, int nFuncionarios)
                                : base(nome, rendaAnual)
        {
            NFuncionarios = nFuncionarios;
        }

        public override double CalculoImposto()
        {
            double tx;

            if(NFuncionarios > 10)
            {
                tx = RendaAnual * 0.14;
            }
            else
            {
                tx = RendaAnual * 0.16;
            }

            return tx;
        }
    }

    
}
