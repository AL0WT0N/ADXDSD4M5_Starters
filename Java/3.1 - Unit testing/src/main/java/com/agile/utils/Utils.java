package com.agile.utils;

public final class Utils { // stop class being inherited

	private Utils() { } // stop creation of this class
	
	public static int toNumber(String s) {
		return Integer.parseInt(s);
	}

	public static boolean isNumeric(String str) {
		return str.matches("[+-]?\\d*(\\.\\d+)?");
	}

	public static char validSeperator(String s) {  // example of a slow method
		int index = 0;
		while (Character.isDigit(s.charAt(index)))
			index++;
		try {
			Thread.sleep(1000);
		} catch (InterruptedException e) {
		}
		return s.charAt(index);
	}
	
	// 
}
