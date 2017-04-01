/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package scratchpad.CodeGolf;

import java.util.*;
import java.lang.*;
import java.io.*;

/**
 *
 * @author Peter arden
 */
public class HelloWorldFibnonacciDistributionValidation {
    
    public static void test (String[] args) throws java.lang.Exception
	{
		String toTest = "";
		Scanner scan = new Scanner(System.in);
 
		do{
			toTest += scan.nextLine();
			if (scan.hasNext()){
				toTest += "\n";
				continue;
			}
		}while (false);
 
		int digitCount = 0, otherCount = 0;
		for (char c : toTest.toCharArray()){
			if (c >= '0' && c <= '9'){
				digitCount++;
			}
			else{
				otherCount++;
			}
		}
		System.out.println("Digits: " + digitCount + " Nondigits: " + otherCount);
 
		int f1 = 1, f2 = 2;
 
		while (true){
			if (f2 == digitCount && f1 == otherCount){
				System.out.println("Valid program");
				break;
			}
			int store = f2;
			f2 += f1;
			f1 = store;
 
			if (f1 > digitCount){
				System.out.println("Invalid program");
				break;
			}
		}
        }
}
