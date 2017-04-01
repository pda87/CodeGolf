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
//http://codegolf.stackexchange.com/questions/100773/build-an-alphabet-pyramid
public class BuildAnAlphabetPyramid {
    
    public String P(int n)
    {
        String a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", o ="", k="",s="";
        int i =0, j=0, l=0;
        java.util.List<String> b = new java.util.ArrayList<String>();
        for (i = 1; i <= n; i++) {
            k = "";
            s = a.substring(0, i);
            l = s.length();
            
            for (j = 0; j < l; j++)
                k += s.toCharArray()[j] + " ";
            
            while(k.length() < n + n)
                k= " " + k;
            
            if(i > 1)
                for (j = l-2; j >= 0; j--)
                    k += s.toCharArray()[j] + " ";           
                        
            k += "\r\n";
            b.add(k);
            o += k;
         }
        
        for (i = b.size()-2; i >= 0; i--)
            o += b.get(i);
                   
        return o;
    }
    
    public String Q(int n){String a="ABCDEFGHIJKLMNOPQRSTUVWXYZ",o="",k="",s="";int i=0,j=0,l=0;java.util.List<String>b=new java.util.ArrayList<String>();for(i=1;i<=n;i++){k="";s=a.substring(0,i);l=s.length();for(j=0;j<l;j++)k+=s.toCharArray()[j]+" ";while(k.length()<n+n)k=" "+k;if(i>1)for(j=l-2;j>=0;j--)k+=s.toCharArray()[j]+" ";k+="\r\n";b.add(k);o+=k;}for(i=b.size()-2;i>=0;i--)o+=b.get(i);return o;}
    
}
