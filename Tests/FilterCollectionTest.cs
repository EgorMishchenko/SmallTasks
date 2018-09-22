using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallTasks.Extensions;
using SmallTasks._2_FilterCollection;

namespace Tests
{
    [TestClass]
    public class FilterCollectionTest
    {
        public FilterCollectionTest()
        {
            Initialize();
        }
        public ICollection<Element> Elements { get; set; }

        [TestMethod]
        public void GetUniqueElementsWithAgeMoreThan20Test()
        {
            var uniquesElements = Elements.GetUniqueWithAgeMoreThan20().ToList();

            Assert.AreEqual("Petr", uniquesElements.First().Name);
            Assert.AreEqual("Ivan", uniquesElements.Last().Name);
        }

        public void Initialize()
        {
            FillElements();
        }

        public void FillElements()
        {
            Elements = new List<Element>()
            {
                new Element(){ Num = 1, Age = 10, Name = "Artem" },
                new Element(){ Num = 2, Age = 21, Name = "Petr" },
                new Element(){ Num = 3, Age = 14, Name = "Kostya" },
                new Element(){ Num = 4, Age = 18, Name = "Valentin" },
                new Element(){ Num = 1, Age = 24, Name = "Ivan" },
                new Element(){ Num = 5, Age = 19, Name = "Alexander" },
                new Element(){ Num = 1, Age = 33, Name = "Pavel" },
                new Element(){ Num = 2, Age = 30, Name = "Dmitriy" },
                new Element(){ Num = 2, Age = 58, Name = "Nikolay" },
                new Element(){ Num = 4, Age = 13, Name = "Vasya" },
            };
        }
    }
}
