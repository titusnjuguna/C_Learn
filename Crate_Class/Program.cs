using System;

namespace Crate_Class
{
    public class Employees
    {
        public string name;
        public int id;
        public string depart;
        public int salary;

        public Employees(int i ,int S,string d , string n){
            this.name = n;
            this.salary = S;
            this.depart = d;
            this.id = i;
        }
        public void display(){
            Console.WriteLine($"{id} {name} {depart} {salary}");
        }
    }
    class Testclass{
       public static void Main(string[] args)
        {
            Employees e1 = new Employees(34,50000,"Tech","Kitito");
            
            e1.display();
        }
        
    }
}

//