using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector3.up * 500);
        }
    
        rb.velocity = Vector3.forward * 20f;
    }

    // look for a collision with another object
    private void OnCollisionEnter(Collision Collision)
    {
       if (Collision.gameObject.tag == "Enemy") 
       {
           Destroy(Collision.gameObject);
       }
    }
}
