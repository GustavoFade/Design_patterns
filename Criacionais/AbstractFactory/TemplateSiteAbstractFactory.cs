using System;
namespace DesingPatterns.Criacionais.AbstractFactory
{
    public class TemplateSiteClient
    {
        public string corHeader;
        public string corBody;
        private readonly ITemplateSiteAbstractFactory _factory;
        public TemplateSiteClient(ITemplateSiteAbstractFactory factory)
        {
            _factory = factory;
            corHeader = _factory.CreateHeaderSite().CorHeader();
            corBody = _factory.CreateBodySite().CorBody();
        }
    }

    public interface ITemplateSiteAbstractFactory
    {
        IAbstractHeaderSite CreateHeaderSite();

        IAbstractBodySite CreateBodySite();
    }

    public class TemplateSiteLigthConcreteFactory : ITemplateSiteAbstractFactory
    {
        public IAbstractHeaderSite CreateHeaderSite()//Produto A
        {
            return new ConcreteHeaderSiteLigth();
        }

        public IAbstractBodySite CreateBodySite()//Produto B
        {
            return new ConcreteBodySiteLigth();
        }
    }

    public class TemplateSiteDarkConcreteFactory : ITemplateSiteAbstractFactory
    {
        public IAbstractHeaderSite CreateHeaderSite()
        {
            return new ConcreteHeaderSiteDark();
        }

        public IAbstractBodySite CreateBodySite()
        {
            return new ConcreteBodySiteDark();
        }
    }

    public interface IAbstractHeaderSite
    {
        string CorHeader();
    }

    public interface IAbstractBodySite
    {
        string CorBody();
    }
    public class ConcreteHeaderSiteDark : IAbstractHeaderSite
    {
        public string CorHeader()
        {
            return "Header Dark";
        }
    }
    public class ConcreteHeaderSiteLigth : IAbstractHeaderSite
    {
        public string CorHeader()
        {
            return "Header Ligth";
        }
    }
    public class ConcreteBodySiteDark : IAbstractBodySite
    {
        public string CorBody()
        {
            return "Bory Dark";
        }
    }
    public class ConcreteBodySiteLigth : IAbstractBodySite
    {
        public string CorBody()
        {
            return "Bory Ligth";
        }
    }
}