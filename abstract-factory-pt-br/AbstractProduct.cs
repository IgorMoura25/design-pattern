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
