using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject explosion;

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

        Debug.Log("Key Picked up");
        //show explosion effect
        Instantiate(explosion, transform.position, transform.rotation);
        collision.gameObject.GetComponent<CharacterController2D>().hasKey=true;
        //Destroy Gameobject
        Destroy(gameObject);
    }
}
