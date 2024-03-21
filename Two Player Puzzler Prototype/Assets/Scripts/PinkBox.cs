using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PinkBox : MonoBehaviour
{
    private GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        player2 = GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player1"))
        {
            if (player2.GetComponent<Rigidbody2D>().gravityScale < 0)
            {
                player2.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
            else
            {
            player2.GetComponent<Rigidbody2D>().gravityScale = -0.5f;
            }

            Destroy(gameObject);
        }
        

    }
}
