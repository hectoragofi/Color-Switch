using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject circle;
    public GameObject agkouri;

    public Transform player;

    public Rigidbody2D rb;
    public float jumpForce = 10f;

    void Start()
    {
        for( int i = 0; i <= 4; i++)
        {
            spawnthings();
        }
    }

    void Update()
    {
        if(transform.position.y - 8 < player.position.y)
        {
            for( int i = 0; i <= 4; i++)
            {
                spawnthings();
            }
        }
    }
    public void spawnthings()
    {
        
        Instantiate(circle,  transform.position, transform.rotation);
        transform.position = new Vector3(transform.position.x,transform.position.y + 5 ,transform.position.z);
        Instantiate(agkouri,  transform.position, transform.rotation);
        transform.position = new Vector3(transform.position.x,transform.position.y + 5 ,transform.position.z);
        //Instantiate(agkouri,  transform.position, transform.rotation);
        //transform.position = new Vector3(transform.position.x,transform.position.y + 5 ,transform.position.z);
    }
}
