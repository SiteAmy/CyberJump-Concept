using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{

    private static int deaths = 0;
    [SerializeField] private Text deathText;


    private void DontDestroyOnLoad(int deaths)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            
            deaths++;
            deathText.text = "Deaths: " + deaths;
            Die();
        }

        else if (collision.gameObject.CompareTag("Win"))
        {
            Win();
        }
    }

    private void Die()
    {
        RestartLevel();
    }

    private void Win()
    {
        RestartLevel();
        Debug.Log("Winner");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void RestartButton()
    {
        RestartLevel();
    }


}
