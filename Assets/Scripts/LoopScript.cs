using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{


    public List<string> studentsNames = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
        
        studentsNames.Add("Geronimo");
        studentsNames.Add("Julieta");
        studentsNames.Add("Raul");
        studentsNames.Add("Romina");

        foreach(string names in studentsNames)
        {
            Debug.Log(names);
        }

        int[] someInts = new int[] { 1, 4, 7, 6, 9, 0 };
        int sum = 0;
        int n = someInts.Length;
        foreach (int i in someInts)
        {            
            sum = sum + i;
            Debug.Log("La suma ahora vale " + sum);
        }
        Debug.Log("La media es igual a " + sum / n);

        

        
        Debug.Log("Algoritmos de búsqueda");

        int objectoPos = -1;
        for (int i = 0; i < studentsNames.Count; i++)
        {
            Debug.Log("Vamos por la iteración número: " + i);
            if (studentsNames[i] == "Geronimo")
            {
                objectoPos = i;
                break;
            }
        }

        if(objectoPos == -1) 
        {
            Debug.Log("No hemos encontrado el objeto que buscabas");
        }
        else
        {
            Debug.Log("El obbjeto buscado se encuentra en la posiciòn" + objectoPos);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
