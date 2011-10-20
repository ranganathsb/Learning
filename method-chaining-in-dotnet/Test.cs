using System.Linq;
using NUnit.Framework;
using FizzWare.NBuilder;

namespace MethodChainingExample
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Example_Of_Method_Chaining()
        {
            var generator = new RandomGenerator();

            var invoices = Builder<Invoice>.CreateListOfSize(50)
                .All().With(x => x.AmountDue = generator.Next(0m, 1000m))
                .Random(20).With(x => x.AmountDue = generator.Next(500m, 1000m))
                .Build();

            Find.SetInvoices(invoices);

            var result = Find.Invoices.With(x => x.AmountDue > 500m).Execute();

            Assert.That(result.Count(), Is.GreaterThan(20));
        }

        [Test]
        public void Branch_Test()
        {
            
        }
         
    }
}