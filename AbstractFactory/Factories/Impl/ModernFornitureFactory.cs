using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Forniture;
using AbstractFactory.Forniture.Impl.ModernForniture;

namespace AbstractFactory.Factories.Impl
{
    public class ModernFornitureFactory : IFornitureFactory
    {
        public IForniture CreateChair()
        {
            return new ModernChair();
        }

        public IForniture CreateSofa()
        {
            throw new NotImplementedException();
        }

        public IForniture CreateTable()
        {
            return new ModernTable();
        }
    }
}