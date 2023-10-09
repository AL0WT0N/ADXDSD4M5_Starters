package com.qa.main;

public class Runner {

	public static void main(String[] args) {
		
//		BankAccount one = new BankAccount("Tom", 1, 25000);
//		
//		one.deposit(5000);
//		
//		one.withdraw(5000);
//		
//		BankAccount two = new BankAccount("Harry", 5000);
//		
//		System.out.println(two.getAccountNum());
//		
//		two.deposit(5000);
//		
//		two.withdraw(5000);
//		
//		CurrentAccount three = new CurrentAccount("Bob", 1, 25000, 5000);
//		
//		three.withdraw(30000);
	
		SavingsAccount four = new SavingsAccount("Sally", 1, 25000, 5);
		
		four.addInterest();
		
		System.out.println(four.getBalance());
	}
	
}
