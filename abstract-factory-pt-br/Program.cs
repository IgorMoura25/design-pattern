namespace abstract_factory
{
    public enum TipoFaturamento
    {
        Locacao = 1
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var terceirizacao = new Faturamento().CriarFaturamentoTerceirizacao(TipoFaturamento.Locacao);
            var assinatura = new Faturamento().CriarFaturamentoAssinatura(TipoFaturamento.Locacao);
            var rac = new Faturamento().CriarFaturamentoRac();

            terceirizacao.Faturar();
            assinatura.Faturar();
            rac.Faturar();
        }
    }
}
