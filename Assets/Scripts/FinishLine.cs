using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class FinishLine : MonoBehaviour
{

[SerializeField] float finishDelay = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0;
            LevelController.Instance.GameOver().SetActive(true);
        }
    }
}
