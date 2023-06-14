using System;
using DesingPatterns.Criacionais.AbstractFactory;
using DesingPatterns.Criacionais.MethodFactory;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFatory();
            MethodFatory();
            
        }
        private static void AbstractFatory()
        {
            var templateLigth = new TemplateSiteClient(new TemplateSiteLigthConcreteFactory());
            System.Console.WriteLine(templateLigth.corHeader);
            System.Console.WriteLine(templateLigth.corBody);
            
            var templateDark = new TemplateSiteClient(new TemplateSiteDarkConcreteFactory());
            System.Console.WriteLine(templateDark.corHeader);
            System.Console.WriteLine(templateDark.corBody);
        }
        private static void MethodFatory()
        {
            var creatorMoto = new MotoCreator();
            var moto = creatorMoto.MethodFactory();
            moto.Entregrar();

            var creatorCarro = new CarroCreator();
            var carro = creatorCarro.MethodFactory();
            carro.Entregrar();
        }
    }
}