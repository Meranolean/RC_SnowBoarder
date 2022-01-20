using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;
    [SerializeField] float finishDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            effect.Play();
            Invoke("ReloadScene", finishDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
