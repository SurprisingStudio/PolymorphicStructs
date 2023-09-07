using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using PolymorphicStructsSourceGeneratorsTests.Tests.B;

namespace PolymorphicStructsSourceGeneratorsTests.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "HeapView.BoxingAllocation")]
    public class NamespaceTest
    {
        [Test]
        public void NamespaceWork()
        {
            Assert.AreEqual(new NamespaceStructImpl().ToNamespaceStruct().DoSth(), 0);
        }
    }
}