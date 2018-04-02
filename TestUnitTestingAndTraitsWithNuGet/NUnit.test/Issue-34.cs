using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace NUnit.test
{
    public class DummyItem
    {
        public DummyItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DataOfItem : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new DummyItem(0, "");
            yield return new DummyItem(3, "BLAH");
        }
    }

    [TestFixture]
    public class TestIssue34
    {

        [TestCaseSource(typeof(DataOfItem))]
        public void Creates_And_Adds_To_Graph_Node_Of_Item(DummyItem uniqueId)
        {
            //Arrange
            var graph = new List<DummyItem>();

            //Act
            var node = new DummyItem(5,"whatever"); 

            //Assert
            Assert.NotNull(node);
            //Assert.AreEqual(uniqueId, node.UniqueId);
            //Assert.AreEqual(1, graph.NodeCount);
            //Assert.AreEqual(0, graph.EdgeCount);
        }
    }
}
