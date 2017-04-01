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
public class BuildMeABrickRoad {
    
    public String R(){
        
        String pattern = "\\  \\__\\  ", output = "";
        
        int c = 0, l =8, d = 0;
        
        for (int i = 0; i < 10; i++) {
            
            for (int j = 0; j < 70; j++) {
                output += pattern.substring(c, c + 1);
                c = c == l ? 3 : c + 1;
            }
            
            //c = c == l ? 3 : c + 1;
            
           if(d == l)
               d = 0;
           else
               d += 2;
           
           c = d;
           
           
            
           output += "\r\n";
        }
        
        return output;
        
    }
}