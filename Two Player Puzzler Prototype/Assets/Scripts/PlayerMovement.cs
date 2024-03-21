using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 10, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 10, ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 5, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.down * 5, ForceMode2D.Impulse);
        }
    }
}
