using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 100f;

    public GameObject player;
    // Update is called once per frame
    void Update()
    {

        player = GameObject.FindWithTag("Player");

        transform.Rotate(0f,0f, speed * Time.deltaTime);
        if(transform.position.y + 10 < player.transform.position.y)
        {
            Destroy(gameObject);
        }
    }


}
