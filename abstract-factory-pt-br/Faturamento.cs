using System;

namespace abstract_factory
{   
    // Concrete Factory A1
    public class Faturamento : FaturamentoFactory
    {
        public override FaturamentoTerceirizacao CriarFaturamentoTerceirizacao(TipoFaturamento tipoFaturamento)
        {
            // OBS: Pode-se abstrair ainda mais esse switch, para evitar duplicação de lógica
            // mas para não atrapalhar no entendimento do design pattern, resolvi não abstraí-lo.
            switch(tipoFaturamento)
            {
                case TipoFaturamento.Locacao:
                    return new FaturamentoLocacaoTerceirizacao();

                default:
                    throw new Exception("Tipo de faturamento desconhecido");
            }
        }

        public override FaturamentoAssinatura CriarFaturamentoAssinatura(TipoFaturamento tipoFaturamento)
        {
            // OBS: Pode-se abstrair ainda mais esse switch, para evitar duplicação de lógica
            // mas para não atrapalhar no entendimento do design pattern, resolvi não abstraí-lo.
            switch(tipoFaturamento)
            {
                case TipoFaturamento.Locacao:
                    return new FaturamentoLocacaoAssinatura();

                default:
                    throw new Exception("Tipo de faturamento desconhecido");
            }
        }

        public override FaturamentoRac CriarFaturamentoRac()
        {
                return new FaturamentoLocacaoRac();
        }
    }
}