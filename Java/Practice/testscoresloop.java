package com.delta.controlflow;

public class MyClass {
	
	public void looping(){
		
		int[] testScores = {87, 75, 90, 92};
		
		for(int i = 0; i < testScores.length; i++){
			testScores[i] = (testScores[i] * 100) / 92;
		}
		
	}
}