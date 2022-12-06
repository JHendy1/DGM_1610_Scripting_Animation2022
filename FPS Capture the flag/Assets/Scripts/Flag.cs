using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Find gameManager
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
