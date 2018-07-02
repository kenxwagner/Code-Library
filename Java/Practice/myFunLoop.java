package com.built2gsd.controlflow;

public class MyClass {
	
	public void myFunLoop(){
		
		char[] bubble = {'b','u','b','b','l','e'};
		
		boolean isThereB = false;
		int countOfB = 0;
		
		for(int i = 0; i< bubble.length; i++){
			if(bubble[i] =='b'){
				isThereB = true;
				countOfB++;
				continue;
			}
		}
	}
}