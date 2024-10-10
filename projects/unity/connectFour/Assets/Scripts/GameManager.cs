using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // load a variable to keep track of who's turns it is, switch between 1 and -1 by multiplying by -1
    // red starts first at 1 and blank is -1

    //track mouse position in update for hovering above piece
    //on click drop the piece

    //then check win fancily
    //use raycast to see if there are any of the same sprites adjacent

    //see how many pathways to check
    //if there is then keep going
    //if we reach 4 then win
    //keep checking the other pathways

    //if pieces number == 42 then game over since thats max out spots and nobody has won
}
