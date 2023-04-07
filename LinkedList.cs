using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkListLab
{
    internal class LinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; }

        public LinkedList() 
        {
            this.Head = null;
            this.Count = 0;
        }

        public void AddFirst(string value)
        {

            //create new node
            Node node = new Node();

            //Assign value to new node
            node.Value = value;

            //create variable (old head node) and assign it node at head
            Node oldNode = Head;

            //assign head to new node
            Head = node;

            //Assign next to old head node
            node.Next = oldNode;

            //THIS WORKS
            //Node node1= new Node();
            //node1.Value = value;
            //node1.Next = Head;
            //Head = node1;

            //Also this
            //Node node = new Node();
            //node.Value = value;
            //Node oldNode = Head;
            //Head = node;
            //node.Next = oldNode;

            //increment count
            Count++;
        }

        public void AddLast(string value)
        {
            Node node = new Node();
            node.Value = value;

            node.Next = null;

            if(Head == null)
            {
                Head = node;
            }

            else
            {
                Node currentNode;
                currentNode = Head;

                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                
                currentNode.Next = node;

            }

            Count++;
        }

        public void RemoveFirst()
        {
            //Node node = new Node();

            if(Head != null)
            {
                Node node = Head;
                Head = Head.Next;
                node = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            //Node node = new Node();
            if(Head != null)
            {
                if(Head.Next == null)
                {
                    Head = null;
                }

                else
                {
                    Node node = new Node();
                    node = Head;
                    while(node.Next.Next != null)
                    {
                        node = node.Next;
                    }

                    Node lastNode = node.Next;
                    node.Next = null;
                    lastNode = null;
                }
            }

            Count--;

        }
        //Retives the value of the node at the given index
        public void GetValue(int index) 
        {
            int counter = 0;
            while(Head != null)
            {
                if(counter == index)
                {
                    break;
                }
                counter++;
                Head = Head.Next;
            }
        }
    }
}
