using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest
{
    public class LinkedList {
        private Node head;
        private int size;

        public LinkedList() {
            this.head = null;
            this.size = 0;
        }

        public bool Empty {
            get { return this.size == 0; }
        }

        public int Size {
            get { return this.size; }
        }

        public object insert(object o) {
            try {
                int index = size;
                if (index < 0)
                    throw new ArgumentOutOfRangeException("Index: " + index);

                if (index > size)
                    index = size;

                Node current = this.head;

                if (this.Empty || index == 0) {
                    this.head = new Node(o, this.head);
                }
                else {
                    for (int i = 0; i < index - 1; i++) {
                        current = current.Next;
                    }
                    current.Next = new Node(o, current.Next);
                }
                size++;
                return o;
            } catch (NullReferenceException ex) {
                Console.WriteLine("1");
                return "";
            }
        }
        
        public void delete(string o) {
            try {
                Node current = this.head;
                if (current.Data.ToString() == o) {
                    this.head = current.Next;
                }
                else {
                    while (current.Next.Data.ToString() != o) {
                        current = current.Next;
                    }
                    current.Next = current.Next.Next;
                }
            }
            catch (NullReferenceException ex) {
                Console.WriteLine("2");
            }
        }    

        public void PrintAll() {
            try {
                int count = 1;
                Node current = head;
                Console.WriteLine("Node" + count + ":" + current.Data);
                while (current.Next != null) {
                    count++;
                    current = current.Next;
                    Console.WriteLine("Node" + count + ":" + current.Data);
                }
            } catch (NullReferenceException ex) {
                Console.WriteLine("3");
            }   
        }
    }
}