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
		// Try your own test here, with a different position and mocked result
		// The above method and the guide in the Lab doc can be used to help
	}
	
	// Add some additional tests using the guide in the Lab doc
	// Even though lab doc uses easymock, you can create equivelents using Mockito
	// If you can't figure it out, ask for help, or switch to easymock and follow the guide exactly
}
