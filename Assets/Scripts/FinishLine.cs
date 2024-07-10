using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class FinishLine : MonoBehaviour
{

    [SerializeField] float finishDelay = 1f;
    [SerializeField] private AudioClip finishSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PlayerController.Instance.IsGameOver = true;
            GetComponent<AudioSource>().PlayOneShot(finishSound);
            LevelController.Instance.GameOver().SetActive(true);
            Time.timeScale = 0;
        }
    }
}
