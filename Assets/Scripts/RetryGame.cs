using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
   /* void Start()
    {
        
    }

    void Update()
    {
       
    }*/
    public void PlayAgian()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Main_menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
