using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{ 

    public float playerHeight = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerHeight, ForceMode2D.Impulse);
        }
    }


void OnCollisionEnter2D()
    {
        SceneManager.LoadScene(0);
    }

}
