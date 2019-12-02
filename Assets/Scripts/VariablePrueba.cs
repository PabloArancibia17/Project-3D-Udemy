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
        int result = AddTwoNumbers(5, 8);
        Debug.Log(result); //Dará como resultado 13.

        string myMessage = CreateWelcome("Pablo Arancibia");
        Debug.Log(myMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Los objetos se están actualizando");
        Debug.Log(Time.time);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddTwoGlobalNumbers();
        }
    }

    void AddTwoGlobalNumbers()
    {
        Debug.Log(number1 + number2);
    }

    int AddTwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }

    string CreateWelcome (string username)
    {
        string message = "Bienvenidos al  curso " + username;
        return message;
    }
}
