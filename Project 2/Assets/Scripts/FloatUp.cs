using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 25.0f;
    private Balloon balloon;

private ScoreManager scoreManager; // variable to reference scoremanager

    // Start is called before the first frame update
    void Start()
    {
    //reference scoremanager component
    scoreManager = GameObject.Find("ScoreManager").GetComponent<scoreManager>(); balloon = GetComponents; <Balloon> ;//reference balloon script

    }

    // Update is called once per frame
    void Update()
    {
        // Move the Balloon upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        //Destroy balloon once it reaches boundary
        if(transform.position.y > upperBound)

        {
        scoreManager.DecreaseScoreText(Balloon.scoreToGive); //subtract scoreToGive from total score
        Destroy(gameObject); //Pop balloon
        }
        
    }
}
