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

        public PessoaJuridica(string nome, double rendaAnual, int nFuncionarios)
                                : base(nome, rendaAnual)
        {
            NFuncionarios = nFuncionarios;
        }

        public override double CalculoImposto()
        {
            

            if(NFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
               return RendaAnual * 0.16;
            }

           
        }
    }

    
}
