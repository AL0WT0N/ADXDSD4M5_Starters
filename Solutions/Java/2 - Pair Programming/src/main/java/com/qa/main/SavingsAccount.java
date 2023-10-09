package com.qa.main;

public class SavingsAccount extends BankAccount {

	private double interestRate;
	
	public SavingsAccount(String customerName, int accountNum, double balance, double interestRate) {
		super(customerName, accountNum, balance);
		this.interestRate = interestRate;
	}

	public SavingsAccount(String customerName, double balance, double interestRate) {
		super(customerName, balance);
		this.interestRate = interestRate;
	}
	
	public void addInterest() { 
		this.setBalance(this.getBalance() + (this.getBalance() * interestRate) / 100);
	}
}
