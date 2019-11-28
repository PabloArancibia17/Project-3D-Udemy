using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime = 60f;

    //Variable que indica el tiempo de juego
    float countdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Es lo mismo que decir "countdown = countdown - Time.deltaTime"
        countdown -= Time.deltaTime;
        Debug.Log("Cuenta atrás: " + countdown);

        if (countdown <= 0)
        {
            Debug.Log("Game Over");

            Coin.coinCounter = 0;

            SceneManager.LoadScene("MainScene");

        }
    }
}
