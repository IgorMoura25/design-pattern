namespace abstract_factory
{
    // Abstract Factory
    public abstract class FaturamentoFactory
    {
        public abstract FaturamentoTerceirizacao CriarFaturamentoTerceirizacao(TipoFaturamento tipoFaturamento); // Pode faturar locação, multa, etc...
        public abstract FaturamentoAssinatura CriarFaturamentoAssinatura(TipoFaturamento tipoFaturamento); // Pode faturar locação, multa, etc...
        public abstract FaturamentoRac CriarFaturamentoRac(); // Rac fatura apenas locação :)
    }
}