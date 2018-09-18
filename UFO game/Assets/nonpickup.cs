using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "interesting pick", menuName = "ipick")]
public class nonpickup : ScriptableObject {
    private string n = "keeping going to pick up a ball for a score of :";
    public int score;

    public Sprite Artwork;

    public void Print()
    {
        Debug.Log(n + score.ToString());
    }

    
	
}
