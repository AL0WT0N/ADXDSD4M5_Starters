package com.qa.main;

public class CurrentAccount extends BankAccount {

	private double overdraftLimit;
	
	public CurrentAccount(String customerName, int accountNum, double balance, double overdraftLimit) {
		super(customerName, accountNum, balance);
		this.overdraftLimit = overdraftLimit;
	}

	public CurrentAccount(String customerName, double balance, double overdraftLimit) {
		super(customerName, balance);
		this.overdraftLimit = overdraftLimit;
	}
	
	@Override
	public void withdraw(int amount) {
		if (amount <= (this.getBalance() + overdraftLimit)) {
			this.setBalance(this.getBalance() - amount);
			System.out.println("Withdrew £" + amount);
			System.out.println("£" + this.getBalance() + " remaining");
		} else {
			System.out.println("Not enough funds");
		}
	}
}
