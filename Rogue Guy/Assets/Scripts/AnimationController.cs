using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animSpeed;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        // Get animator and animator component.
        animSpeed = GetComponent<Animator>();
        Animation = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) StopAnim();

        if (Input.GetKeyDown(KeyCode.S)) StopAnim();
        
    }

    // Control animation via animator and keys
    void PlayAnim()
    {
        animSpeed.speed = 1f;
        Debug.Log("Animation is Playing");
    }

    void StopAnim()
    {
        animSpeed.speed = 0f;
        Debug.Log("Animation is Paused");
    }

}
