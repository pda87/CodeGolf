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
//http://codegolf.stackexchange.com/questions/100858/display-a-chain-of-little-mountains-with-an-odd-number-on-the-top-of-it
public class OddMountains {
 
    public String M(int n) {
        String o = " ";
        int i=0;
//        for (; i < n; i++)
        for (; i < n;i++)

            if(i % 2 > 0)
                o += i + "  ";
                
        o += "\n";
        
        for (i = 0; i < n/2; i++)
            o += "/ \\";
        
        return o;       
    }

    public String N(int n){String o=" ";int i=0;for(;i<n;i++)if(i%2>0)o+=i+"  ";o+="\n";for(i=0;i<n/2;i++)o+="/ \\";return o;}
}
