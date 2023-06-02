using System;

public interface IAnimal
{
    void HacerSonido();
    void LlamarAmigo();
}

public class Perro : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("¡Guau! Woof!");
    }
    public void LlamarAmigo()
    {
        Console.WriteLine("¡Ven amigo perro!");
    }
}

public class Gato : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("¡Miau! Meow!");
    }
    public void LlamarAmigo()
    {
        Console.WriteLine("¡Ven amigo gato!");
    }
}
public class Pajaro : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("¡Pío Pío! Quququ!");
    }

    public void LlamarAmigo()
    {
        Console.WriteLine("¡Ven amigo pájaro!");
    }
}
public class Program
{
    public static void Main()
    {
        IAnimal miGato = new Gato();
        IAnimal miPerro = new Perro();
        IAnimal miPajaro = new Pajaro();

        miGato.HacerSonido();
        miGato.LlamarAmigo();

        miPerro.HacerSonido();
        miPerro.LlamarAmigo();

        miPajaro.HacerSonido();
        miPajaro.LlamarAmigo();
    }
}