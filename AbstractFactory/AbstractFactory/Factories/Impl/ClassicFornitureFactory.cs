using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Forniture;
using AbstractFactory.Forniture.Impl.ClassicForniture;

namespace AbstractFactory.Factories.Impl
{
    public class ClassicFornitureFactory : IFornitureFactory
    {
        public IForniture CreateChair()
        {
            return new ClassicChair();
        }

        public IForniture CreateSofa()
        {
            throw new NotImplementedException();
        }

        public IForniture CreateTable()
        {
            return new ClassicTable();
        }
    }
}