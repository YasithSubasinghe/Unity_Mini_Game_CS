using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//new Scene for loseScreen

public class Player : MonoBehaviour
{
    public float jumpForce;

   // public int marks; //my experiment

    private Rigidbody2D _rBody;  //make rigidbody reference

    // public GameObject gameOverPanel;
   // public GameOverScreen GameOverScreen;  //newly added

    


private void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
    }

   

    void Update() // call frame by frame
    {
      
        Jump();
        PlayerBound();
    }

    private void Jump()//press space to jump
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rBody.velocity = new Vector2(0, jumpForce);
        }
    }
    private void PlayerBound() //stop player in higher bound
    {
        if (transform.position.y >= 4f)
        {
            transform.position = new Vector2(0, 4f);
        }
    }
    // identify trigger

    private void OnTriggerEnter2D(Collider2D target) //trigger collution
    {
        if (target.CompareTag("Arrow"))
        {
            // gameOverPanel.SetActive(true);

            // Time.timeScale = 0;
            //WaitForSeconds=(5f);
            // new WaitForSeconds(6);//new 20
     


            SceneManager.LoadScene("LoseScreen");//Lose Screen load

            //GameOverScreen.Setup(marks); //newly added
        }
        /* if (Input.GetKeyDown(KeyCode.Space))//my
         {
             marks++;
             print(marks);
         }  //my
        */
    }


    

  

}//class
