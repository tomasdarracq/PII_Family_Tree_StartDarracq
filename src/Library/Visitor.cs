using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Visitor
    {
        public int edadTotal = 0;
        public int olderAge = 0;
        public Person olderPerson;
        public Person LongerNamePerson = new Person("",1);
        public void VisitTotalAge(Node node)
        {
            edadTotal = edadTotal + node.person.Age;
            foreach (var i in node.Children)
            {
                i.Accept(this);
            }
        }
        public void VisitOlderSon(Node node)
        {
            if(node.person.Age>olderAge){
               olderAge = edadTotal +node.person.Age;
               olderPerson = node.person;
            }
             
            foreach (var i in node.Children)
            {
                i.AcceptOlderSon(this);
            }
        }
         public void VisitLongerName(Node node)
        {
            if(node.person.Name.Length>LongerNamePerson.Name.Length){
               LongerNamePerson= node.person;
            }
             
            foreach (var i in node.Children)
            {
                i.AcceptLongerName(this);
            }
        }
    }
}