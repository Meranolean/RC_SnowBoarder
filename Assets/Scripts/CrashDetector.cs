using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deadDelay = 0.5f;
    [SerializeField] ParticleSystem effect;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            effect.Play();
            Invoke("ReloadScene", deadDelay);
        }    
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
