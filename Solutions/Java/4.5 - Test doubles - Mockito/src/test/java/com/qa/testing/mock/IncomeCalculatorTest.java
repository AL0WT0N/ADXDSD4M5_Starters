package com.qa.testing.mock;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.junit.MockitoJUnitRunner;


@RunWith(MockitoJUnitRunner.class)
public class IncomeCalculatorTest {

	@Mock
	private ICalcMethod calcMethod;

	@InjectMocks
	private IncomeCalculator calc;
	
	@Test
	public void testCalcBoss() {
		Mockito.when(calcMethod.calc(Position.BOSS)).thenReturn(70000d);
		
		calc.setCalcMethod(calcMethod);
		calc.setPosition(Position.BOSS);
		
		//           expected, actual, delta
		assertEquals(70000d, calc.calc(), 0);
	}
	
	@Test
	public void testCalcProgrammer() {
		Mockito.when(calcMethod.calc(Position.PROGRAMMER)).thenReturn(50000d);
		
		calc.setCalcMethod(calcMethod);
		calc.setPosition(Position.PROGRAMMER);
		
		//           expected, actual, delta
		assertEquals(50000d, calc.calc(), 0);
	}
	
	@Test(expected = RuntimeException.class)
	public void testNoCalc() {
		calc.setCalcMethod(null);
		calc.setPosition(Position.SURFER);
		calc.calc();
	}
	
	@Test(expected = RuntimeException.class)
	public void testNoPosition() {
		calc.setCalcMethod(calcMethod);
		calc.setPosition(null);
		calc.calc();
	}	
}
