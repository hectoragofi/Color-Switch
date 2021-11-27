using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string currentColor;
    
    public int score = 0;
    public TMP_Text txt; 
    public Color Blue;
    public Color Yellow;
    public Color Pink;
    public Color Purple;

    private string cs;
    public void Start()
    {

        txt.text = score.ToString();
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        txt.text = "" + score;
    }

    void SetRandomColor()
    {
        int index = Random.Range(0,4);

        if (index == 0 && currentColor != "Blue")
        {
            currentColor = "Blue";
            sr.color = Blue;
        }


        else if (index == 1 && currentColor != "Yellow")
        {
            currentColor = "Yellow";
            sr.color = Yellow;
        }

        else if (index == 2 && currentColor != "Pink")
        {
            currentColor = "Pink";
            sr.color = Pink;
        }
        else
        {
            currentColor = "Purple";
            sr.color = Purple;
        }
    }

    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.name != currentColor && collission.gameObject.tag != "Agouri")
        {
            Debug.Log("Loser");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        }

        if (collission.gameObject.tag == "Agouri")
        {
            //etRandomColor();
            //sr.color = colormake.currentColour;
            SetRandomColor();
            Destroy(collission.gameObject);
            score ++;
        }
    }

}
