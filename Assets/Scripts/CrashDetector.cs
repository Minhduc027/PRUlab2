using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float crashDelay = 0.5f;
    [SerializeField] private AudioClip crashSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ground")
        {
            PlayerController.Instance.IsGameOver = true;
            LevelController.Instance.GameOver().SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Time.timeScale = 0;
        }
    }
}
