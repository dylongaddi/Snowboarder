using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelay = 1F;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Head")
        {
            Invoke("ReloadScene", crashDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
