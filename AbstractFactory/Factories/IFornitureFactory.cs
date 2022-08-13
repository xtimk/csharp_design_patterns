using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Forniture;

namespace AbstractFactory.Factories
{
    public interface IFornitureFactory
    {
        public IForniture CreateChair();
        public IForniture CreateTable();
        public IForniture CreateSofa();
    }
}