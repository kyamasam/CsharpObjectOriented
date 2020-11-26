using System;

namespace classes
{
    public class GiftCardAccount:BankAccount
    {
        //abstract method is one that the derived class must implement
        //the base class does not provide any implementation for abstract methods
        //virtual method is a method that any derived class may choose to reimplement
        private decimal _monthlyDeposit;
        public GiftCardAccount(string name , decimal initialBalance, decimal monthlyDeposit = 0) 
            : base(name,initialBalance) => _monthlyDeposit = monthlyDeposit;
            
        public override void PerformMonthEndTransactions(){
            if(_monthlyDeposit != 0){
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add Monthly deposit");
            }
        }
        
        
    }
}