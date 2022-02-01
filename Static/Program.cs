using System;

namespace Static
{
    public class Account{
        public string name;
        public string  residence;
        public int balance;
        public static double interest;

        public Account(string nam,string res , int bal){
            this.name = nam;
            this.residence =res;
            this.balance = bal;
        }
        static Account(){
            interest = 0.0985;
        }

        public void display(){
            Console.WriteLine($"Hello {name}, thank you for choosing Equity, your account balance is Ksh {balance}");
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Account cust1 = new Account("Kush","Utawala",1200000);
            cust1.display();
        }
    }
}
