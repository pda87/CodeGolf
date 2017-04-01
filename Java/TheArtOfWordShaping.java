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
public class TheArtOfWordShaping {

    public String T(int[][] m, String b) {
        int l = m.length,a=0;
        String o = "";
        for(int i = 0; i < l; i++)
        {
            for(int j = 0; j < l; j++)
            {
                if(m[i][j] == 1 && a < b.length())
                {
                    o += Character.toString(b.toCharArray()[a]);
                    a++;
                    
                    if(a == b.length() - 1)
                        a = 0;
                }
                else
                 o += " ";
            }
            o += "\n";
        }
        return o;
    }
    
    public String U(int[][]m,String b){int l=m.length,a=0;String o="";for(int i=0;i<l;i++){for(int j=0;j<l;j++){if(m[i][j]==1&&a<b.length()){o+=Character.toString(b.toCharArray()[a]);a++;if(a== b.length()-1)a=0;}else o+=" ";}o+="\n";}return o;}
    
}
