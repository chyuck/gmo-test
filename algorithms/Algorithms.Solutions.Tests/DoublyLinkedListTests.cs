using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Algorithms.Solutions.DoublyLinkedList;

namespace Algorithms.Solutions.Tests
{
    [TestFixture]
    public class DoublyLinkedListTests
    {
        [Test]
        [TestCase("a")]
        [TestCase(null)]
        public void Test_AddValueToTheEnd_When_LinkedList_Is_Empty(string value)
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();

            // act
            linkedList.AddValueToTheEnd(value);

            // assert
            var values = linkedList.ToArray();
            CollectionAssert.AreEqual(new[] {value}, values);
        }
        
        [Test]
        [TestCase("b")]
        [TestCase(null)]
        public void Test_AddValueToTheEnd_When_LinkedList_Is_Not_Empty(string value)
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();
            linkedList.AddValueToTheEnd("a");
            
            // act
            linkedList.AddValueToTheEnd(value);

            // assert
            var values = linkedList.ToArray();
            CollectionAssert.AreEqual(new[] {"a", value}, values);
        }
        
        [Test]
        [TestCase("a")]
        [TestCase(null)]
        public void Test_RemoveValue_When_LinkedList_Has_Only_One_Value(string value)
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();
            linkedList.AddValueToTheEnd(value);
            
            // act
            linkedList.RemoveValue(value);

            // assert
            var values = linkedList.ToArray();
            CollectionAssert.IsEmpty(values);
        }
        
        [Test]
        [TestCase("a")]
        [TestCase(null)]
        public void Test_RemoveValue_When_Value_Is_First(string value)
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();
            linkedList.AddValueToTheEnd(value);
            linkedList.AddValueToTheEnd("b");
            
            // act
            linkedList.RemoveValue(value);

            // assert
            var values = linkedList.ToArray();
            CollectionAssert.AreEqual(new[] {"b"}, values);
        }
        
        [Test]
        [TestCase("a")]
        [TestCase(null)]
        public void Test_RemoveValue_When_Value_Is_Last(string value)
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();
            linkedList.AddValueToTheEnd("b");
            linkedList.AddValueToTheEnd(value);
            
            // act
            linkedList.RemoveValue(value);

            // assert
            var values = linkedList.ToArray();
            CollectionAssert.AreEqual(new[] {"b"}, values);
        }
        
        [Test]
        [TestCase("a")]
        [TestCase(null)]
        public void Test_RemoveValue_When_Value_Is_Middle(string value)
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();
            linkedList.AddValueToTheEnd("b");
            linkedList.AddValueToTheEnd(value);
            linkedList.AddValueToTheEnd("c");
            
            // act
            linkedList.RemoveValue(value);

            // assert
            var values = linkedList.ToArray();
            CollectionAssert.AreEqual(new[] {"b", "c"}, values);
        }
        
        [Test]
        public void Test_Foreach()
        {
            // arrange
            var linkedList = new DoublyLinkedList<string>();
            linkedList.AddValueToTheEnd("a");
            linkedList.AddValueToTheEnd("b");
            linkedList.AddValueToTheEnd("c");

            var results = new List<string>();
            
            // act
            foreach (var value in linkedList)
            {
                results.Add(value);
            }

            // assert
            CollectionAssert.AreEqual(new[] {"a", "b", "c"}, results);
        }
    }
}