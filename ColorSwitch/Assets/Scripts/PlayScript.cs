using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{

    public Rigidbody2D Player;

    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PauseGame ()
    {
        //Time.timeScale = 0;
        Player.gravityScale = 0;
    }

    public void ResumeGame ()
    {
        //Time.timeScale = 1;
        Player.gravityScale = 3;
        Destroy(gameObject);
    }

}
