using System;
using DesingPatterns.Criacionais.AbstractFactory;
using DesingPatterns.Criacionais.MethodFactory;
using DesingPatterns.Criacionais.Singleton;
using System.Threading;


namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFatory();
            MethodFatory();
            EstadoSingleton.GetIntance();
            TestEstadoSingletonTheadSafety();
        }
        private static void TestEstadoSingletonTheadSafety()
        {
            Thread process1 = new Thread(() =>
            {
                TestSingletonTheadSafety("process1");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingletonTheadSafety("process2");
            });
            Thread process3 = new Thread(() =>
            {
                TestSingletonTheadSafety("process3");
            });
            Thread process4 = new Thread(() =>
            {
                TestSingletonTheadSafety("process4");
            });
            Thread process5 = new Thread(() =>
            {
                TestSingletonTheadSafety("process5");
            });
            process1.Start();
            process2.Start();
            process3.Start();
            process4.Start();
            process5.Start();
            
            process1.Join();
            process2.Join();
            process3.Join();
            process4.Join();
            process5.Join();
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
        void TestSingletonTheadSafety(string value)
        {
            Console.WriteLine(value);
            EstadoSingletonTheadSafety.GetIntance();
        } 
    }
}