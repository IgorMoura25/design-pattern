using System;

namespace abstract_factory
{
    public enum TipoFaturamento
    {
        Locacao = 1
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var terceirizacao = new Faturamento().CriarFaturamentoTerceirizacao(TipoFaturamento.Locacao);
            var assinatura = new Faturamento().CriarFaturamentoAssinatura(TipoFaturamento.Locacao);
            var rac = new Faturamento().CriarFaturamentoRac();

            terceirizacao.Faturar();
            assinatura.Faturar();
            rac.Faturar();
        }
    }

    // Abstract Factory
    public abstract class FaturamentoFactory
    {
        public abstract FaturamentoTerceirizacao CriarFaturamentoTerceirizacao(TipoFaturamento tipoFaturamento); // Pode faturar locação, multa, etc...
        public abstract FaturamentoAssinatura CriarFaturamentoAssinatura(TipoFaturamento tipoFaturamento); // Pode faturar locação, multa, etc...
        public abstract FaturamentoRac CriarFaturamentoRac(); // Rac fatura apenas locação :)
    }

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

    // OBS: Esses abstract products poderiam ter relação uns com os outros. Neste exemplo não faz sentido, mas no comentado abaixo faz.

    // /// <summary>
    // /// The 'AbstractProductA' abstract class
    // /// </summary>
    // abstract class Herbivore
    // {
    // }
    //
    // /// <summary>
    // /// The 'AbstractProductB' abstract class
    // /// </summary>
    // abstract class Carnivore
    // {
    //     public abstract void Eat(Herbivore h); // Aqui a classe abstrata Carnívoro, come a classe Abstrata Herbívoro, gerando uma relação ou dependência.
    // }

    // Abstract Product A
    public abstract class FaturamentoTerceirizacao
    {
        public abstract void Faturar();
    }

    // Abstract Product B
    public abstract class FaturamentoAssinatura
    {
        public abstract void Faturar();
    }

    // Abstract Product C
    public abstract class FaturamentoRac
    {
        public abstract void Faturar();
    }

    // Product A
    public class FaturamentoLocacaoTerceirizacao : FaturamentoTerceirizacao
    {
        public override void Faturar()
        {
            Console.WriteLine("Faturando Locação Terceirização");
        }
    }

    public class FaturamentoLocacaoAssinatura : FaturamentoAssinatura
    {
        public override void Faturar()
        {
            Console.WriteLine("Faturando Locação Assinatura");
        }
    }

    public class FaturamentoLocacaoRac : FaturamentoRac
    {
        public override void Faturar()
        {
            Console.WriteLine("Faturando Locação Rac");
        }
    }
}
