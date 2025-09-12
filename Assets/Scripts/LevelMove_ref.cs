using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

 
public class LevelMove_ref : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.tag == "Player") {
            Debug.Log($"It works");
        SceneManager.LoadScene("Room_2");
        }
    }
}
 