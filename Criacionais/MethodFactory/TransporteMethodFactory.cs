using System;
namespace DesingPatterns.Criacionais.MethodFactory
{
    public interface ICreator
    {
        ITransporte MethodFactory();
    }

    public class MotoCreator : ICreator
    {
        public ITransporte MethodFactory()
        {
            return new Moto();
        }
    }

    public class CarroCreator : ICreator
    {
        public ITransporte MethodFactory()
        {
            return new Carro();
        }
    }

    public interface ITransporte
    {
        void Entregrar();
    }
    public class Moto : ITransporte
    {
        public void Entregrar()
        {
            System.Console.WriteLine("Entregando de moto!");
        }
    }
    public class Carro : ITransporte
    {
        public void Entregrar()
        {
            System.Console.WriteLine("Entregando de carro!");
        }
    }
}