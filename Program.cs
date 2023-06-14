using System;
using DesingPatterns.Criacionais.AbstractFactory;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFatory();
            
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
    }
}