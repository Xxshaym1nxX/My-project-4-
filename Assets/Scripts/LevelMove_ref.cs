using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

 
public class LevelMove_Ref : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.tag == "Player") {
        SceneManager.LoadScene("Room_2");
        }
    }
}
 