using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" || collision.name == "Player" || collision.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
