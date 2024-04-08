using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene", reloadDelay);
            Debug.Log("You crashed sucka!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
