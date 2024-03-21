using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBox : MonoBehaviour
{
    private GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player2"))
        {
            if(player1.GetComponent<Rigidbody2D>().gravityScale < 0)
            {
                player1.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
            else
            {
                player1.GetComponent<Rigidbody2D>().gravityScale = -0.5f;
            }
        
            Destroy(gameObject);
        }
        
    }
}
