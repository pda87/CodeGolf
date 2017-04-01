/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package scratchpad.CodeGolf;

/**
 *
 * @author Peter arden
 */
public class FibonacciSequence {

    public String GetFibonacciResult(int n) {
        
        return String.format("The number %1$s item in"
                + " the Fibonacci Series is: %2$s",
                Integer.toString(n),
                Integer.toString(GetFibonacciIndex(n)));
        
    }
    
    private int GetFibonacciIndex(int n) {
        
        int[] fibonacciArray = new int[n + 3];
        
        fibonacciArray[0] = 0;
        fibonacciArray[1] = 1;
        fibonacciArray[2] = 1;
        
        for (int i = 3; i < fibonacciArray.length; i++) {
            
            fibonacciArray[i] = fibonacciArray[i-2] + fibonacciArray[i-1];
            
        }
        
        return fibonacciArray[n];
    }
}
