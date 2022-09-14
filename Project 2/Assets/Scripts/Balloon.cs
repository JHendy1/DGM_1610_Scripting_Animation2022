using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Increases scale each time balloon is clicked

    // Start is called before the first frame update
    void Start()
    {
         

    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;

        //Increasae balloon volume
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            //scoreManager.IcreaseScoreText(scoreToGive)
            Destroy(gameObject);
        }
    } 
}