using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public Person person;

        private List<Node> children = new List<Node>();

        public int Person {
            get
            {
                return this.Person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person p)
        {
            this.person = p;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        /*
        public int GetTotalAge()
        {
            int totalAge = 0;
            for (int i = 0; i < this.children.Count; i++)
            {
                totalAge= totalAge+ this.children[i].person.Age;
            }
            return totalAge;
        }
        */
        
        public void Accept(Visitor visitor)
        {
            visitor.VisitTotalAge(this);
            
        }
        public void AcceptOlderSon(Visitor visitor)
        {
            visitor.VisitOlderSon(this);
            
        }
        public void AcceptLongerName(Visitor visitor)
        {
            visitor.VisitLongerName(this);
            
        }
    }
}
