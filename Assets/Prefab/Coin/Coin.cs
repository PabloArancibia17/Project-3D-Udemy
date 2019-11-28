using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Se utiliza variable estática dado que se aplica una sola a todos los objetos "Coin"
    public static int coinCounter;

    // Start is called before the first frame update
    void Start()
    {
        //Código que nos da un contador de monedas, en este caso suma una moneda
        Coin.coinCounter++;
        Debug.Log("Se ha creado 1 moneda, en este momento hay " + Coin.coinCounter + " Monedas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //Se resta una moneda al contador
        Coin.coinCounter--;
        Destroy(gameObject);
        Debug.Log("Se ha agarrado una moneda, en este momento hay " + Coin.coinCounter + " monedas");

        if (Coin.coinCounter == 0)
        {
            Debug.Log("Se ha terminado el juego");

            //Destruyo el gamemanager para frenar el tiempo
            GameObject gameManager = GameObject.Find("GameManager");
            Destroy(gameManager);

            GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
            foreach(GameObject fireworks in fireworksSystem)
            {
                fireworks.GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
