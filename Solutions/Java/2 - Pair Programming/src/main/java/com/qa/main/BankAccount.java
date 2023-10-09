package com.qa.main;

public class BankAccount {

	private String customerName;
	private int accountNum;
	private double balance;
	
	private static int accountTracker = 100000;
	
	public BankAccount(String customerName, int accountNum, double balance) {
		this.customerName = customerName;
		this.accountNum = accountNum;
		this.balance = balance;
	}
	
	public BankAccount(String customerName, double balance) {
		this.customerName = customerName;
		this.balance = balance;
		this.accountNum = ++accountTracker;
	}

	public void deposit(int amount) {
		this.balance += amount;
		System.out.println("Deposited £" + amount);
		System.out.println("Total balance is now: £" + this.balance);
	}
	
	public void withdraw(int amount) {
		if (amount <= balance) {
			this.balance -= amount;
			System.out.println("Withdrew £" + amount);
			System.out.println("£" + this.balance + " remaining");
		} else {
			System.out.println("Not enough funds");
		}
	}
	
	public String getCustomerName() {
		return customerName;
	}
	
	public void setCustomerName(String customerName) {
		this.customerName = customerName;
	}
	
	public int getAccountNum() {
		return accountNum;
	}
	
	public void setAccountNum(int accountNum) {
		this.accountNum = accountNum;
	}
	
	public double getBalance() {
		return balance;
	}
	
	public void setBalance(double balance) {
		this.balance = balance;
	}
}
