namespace Library
{
    public class Person{
        public string Name {set;get;}
        public int Age {set;get;}
        
        public Person(string name, int age){
            this.Name=name;
            this.Age=age;
        }
    }
}