﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest
{
    public class Node
    {
        private object data;
        private Node next;

        public Node(object data, Node next) {
            this.data = data;
            this.next = next;
        }

        public object Data {
            get { return this.data;  }
            set { this.data = value; }
        }

        public Node Next {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
