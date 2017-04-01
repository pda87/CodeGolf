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
public class DrawAnASCIIChessBoard {
 
    public String C() {
        
        String r = "........\n";
        return "rnbqkbnr\n"+"pppppppp\n"+r+r+r+r+"PPPPPPPP\n"+"RNBQKBNR\n";
        
        //String b = "rnbqkbnr\n";
        //String p = "pppppppp\n";
        
        //return b+p+r+r+r+r+(p+b).toUpperCase();
    }
    
    public String D(){String r="........\n";return"rnbqkbnr\n"+"pppppppp\n"+r+r+r+r+"PPPPPPPP\n"+"RNBQKBNR\n";}
    
    //public String D(){String b="rnbqkbnr\n";String p="pppppppp\n";String r="........\n";return b+p+r+r+r+r+(p+b).toUpperCase();}
    
}
