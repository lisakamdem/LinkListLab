using System;

namespace LinkListLab
{
    public class Tests
    {
        private LinkedList sll;
        [SetUp]
        public void Setup()
        {
            sll = new LinkedList();

            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Joe Schmoe");
            sll.AddLast("Sam Sammerson");

            //List: Joe Schmoe
            //      John Smith
            //      Jane Doe
            //      Bob Bobberson
            //      Sam Sammerson
        }

        [Test]
        public void TestAddBeginning()
        {

            sll.AddFirst("Joe Blow");

            //assert list has "Joe Blow"
            string expectedName = "Joe Blow";
            string actualName = sll.Head.Value;
            Assert.AreEqual(expectedName, actualName);

        }

        [Test]
        public void TestAddEnd()
        {
            sll.AddLast("Dave Daverson");
            Node found = sll.Head;
            //Node found;
            string expectedName = "Dave Daverson";

           while(found != null)
           {
                if(found.Next == null)
                {
                    break;
                }

                found = found.Next;
           }
            string actualName = found.Value;
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void TestRemoveFirst() 
        {
            sll.RemoveFirst();

            string expectedName = "John Smith";
            string actualName = sll.Head.Value;
            Assert.AreEqual(expectedName, actualName);

        }

        [Test]
        public void TestRemoveEnd()
        {
            sll.RemoveLast();
            Node found = sll.Head;
            string expectedName = "Bob Bobberson";
            while (found != null)
            {
                if (found.Next == null)
                {
                    break;
                }

                found = found.Next;
            }
            string actualName = found.Value;
            Assert.AreEqual(expectedName, actualName);

        }

        [Test]
        public void TestGetValue()
        {
            sll.GetValue(2);

            string expectedName = "Jane Doe";
            string actualName = sll.Head.Value;
            Assert.AreEqual(expectedName, actualName);

        }

        [Test]
        public void TestSizeList()
        {
            //assert that the count is 1
            //This works
            int expectedCount = 5;
            int actualCount = sll.Count;
            Assert.AreEqual(expectedCount, actualCount);

        }
        //can make another one to test that count is 2
        [TearDown]
        public void Teardown()
        {
            sll.Head = null;
            sll.Count = 0;
        }
    }
}