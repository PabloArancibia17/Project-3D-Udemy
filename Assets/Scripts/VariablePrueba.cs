using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablePrueba : MonoBehaviour
{
    public int number1 = 17;
    public int number2 = 7;


   

    private void Awake()
    {
        Debug.Log("Los objetos se han despertado");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Los objetos han arrancado");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Los objetos se están actualizando");
        Debug.Log(Time.time);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddTwoNumbers();
        }
    }

    void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);
    }
}
