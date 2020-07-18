using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // GameManager gm = new GameManager();
            // gm.gameObject.GetComponent<GameManager>().lives = gm.gameObject.GetComponent<GameManager>().lives + 1;
            pickup(collision);
            //  DestroyObject(collision.gameObject);
        }
    }
    void pickup(Collider2D collision)
    {

        Debug.Log("At Door");
        //show explosion effect
        if (collision.gameObject.GetComponent<CharacterController2D>().hasKey == true)
        {
            animator.SetBool("doorOpen", true);
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        
        
    }
}
