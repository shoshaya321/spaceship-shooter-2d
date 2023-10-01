using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor2D : MonoBehaviour
{
    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
         if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}




