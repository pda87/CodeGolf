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


//https://codegolf.stackexchange.com/questions/101180/multi-lingual-challenge
//true false
//wahr, falsch
//In C#, bool.ToString() gives "True" or "False"
//In Java, it's "true" or "false"
public class MultiLingualChallenge {
     
    public String M(Boolean b)
    {
      String s = b + "";
      if (s == "True")
        return "Wahr";
      else if (s == "False")
        return "Falsch";
      else
        return b + "";
    }
    
    public String N(Boolean b){String s=b+"";if(s=="True")return "Wahr";else if(s=="False")return "Falsch";else return b+"";}
    
}
