package com.agile.calculator;

import static org.junit.Assert.assertEquals;

import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

import com.agile.calculator.Calculator;

public class CalculatorTest {

	private static Calculator calculator;
	
	@BeforeClass
	public static void setup() {
		calculator = new Calculator();
	}

	@Test
	public void subtractTest() {
		assertEquals(2, calculator.subtract("5,3"));
	}

	@Test
	public void subtract2Test() {
		assertEquals(-8, calculator.subtract("-5,3"));
	}

	@Test
	public void subtract3Test() {
		assertEquals(2, calculator.subtract("4,2"));
	}

	@Test
	public void divide() {
		assertEquals(5, calculator.divide("10,2"));
	}
	@Test
	public void divide2() {
		assertEquals(-5, calculator.divide("10,-2"));
	}
	@Test
	public void multiply() {
		assertEquals(50, calculator.multiply("25,2"));
	}
	@Test
	public void multiply2() {
		assertEquals(600, calculator.multiply("150,4"));
	}
	
	@Test(expected = java.lang.ArithmeticException.class)
	public void dividewithsomeexception() {
		calculator.divide("10,0");
	}

}
