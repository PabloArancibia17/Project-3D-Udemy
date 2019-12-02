using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesitionsScript : MonoBehaviour
{

    public bool willItRain = false;
    // Start is called before the first frame update
    void Start()
    {
        /*if (willItRain)
        {
            Debug.Log("Lleva paraguas");
        } else
        {
            Debug.Log("No lleves paraguas");
        }*/

        bool iAmLate = true;
        bool isThereSomeTraffic = false;

        if (iAmLate && !isThereSomeTraffic)
        {
            Debug.Log("Acelera tranquilo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool EnterTheParty(int age, int money)
    {
        if (age >= 18 && money >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
