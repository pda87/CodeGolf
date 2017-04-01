/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package scratchpad.CodeGolf;

//https://codegolf.stackexchange.com/questions/74164/manage-trash-so



/**
 *
 * @author Peter arden
 */

import java.util.Arrays;
public class ManageTrashSo {
    
    public boolean M(String a, String b) {
        char[] A = a.toUpperCase().replace(" ", "").toCharArray();
        char[] B = b.toUpperCase().replace(" ", "").toCharArray();
        Arrays.sort(A);
        Arrays.sort(B);
        return Arrays.equals(A, B);
    }

    
    public boolean N(String a,String b){char[]A=a.toUpperCase().replace(" ","").toCharArray();char[]B=b.toUpperCase().replace(" ","").toCharArray();Arrays.sort(A);Arrays.sort(B);return Arrays.equals(A,B);}
    
        
}
