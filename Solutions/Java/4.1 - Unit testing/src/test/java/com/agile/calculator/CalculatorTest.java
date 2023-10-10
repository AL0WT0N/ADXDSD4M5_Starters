package com.agile.calculator;

import static org.junit.Assert.*;

import org.junit.BeforeClass;
import org.junit.Test;

public class CalculatorTest {

	static Calculator calc;
	
	@BeforeClass
	public static void setup(){
		calc = new Calculator();
	}
	
	@Test
	public void subtractionTest(){
		assertEquals(10, calc.subtract("20,10"));
	}
	
	@Test
	public void subtractionTestNoComma(){
		assertEquals(-9999, calc.subtract("20 10"));
	}
	
	@Test
	public void multiplyTest(){
		assertEquals(10, calc.multiply("5,2"));
	}
	
	@Test
	public void divideTest(){
		assertEquals(10, calc.divide("100,10"));
	}
	
	@Test
	public void divideTestNoComma(){
		assertEquals(10, calc.divide("100 10"));
	}
	
	@Test(expected=ArithmeticException.class)
	public void divideByZeroTest(){
		assertEquals(10, calc.divide("100,0"));
	}
	
	
}
