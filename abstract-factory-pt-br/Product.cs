using System;

namespace abstract_factory
{  
    // Product A
    public class FaturamentoLocacaoTerceirizacao : FaturamentoTerceirizacao
    {
        public override void Faturar()
        {
            Console.WriteLine("Faturando Locação Terceirização");
        }
    }

    // Product B
    public class FaturamentoLocacaoAssinatura : FaturamentoAssinatura
    {
        public override void Faturar()
        {
            Console.WriteLine("Faturando Locação Assinatura");
        }
    }

    // Product C
    public class FaturamentoLocacaoRac : FaturamentoRac
    {
        public override void Faturar()
        {
            Console.WriteLine("Faturando Locação Rac");
        }
    }
}