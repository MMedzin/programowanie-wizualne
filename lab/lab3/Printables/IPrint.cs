using System;

namespace Printables
{
    public interface IPrintable
    {
        System.Guid ID { get; set; }
        void Print();
    }

    public interface IPublicPrintable 
    {
        void Print();
    }
}
