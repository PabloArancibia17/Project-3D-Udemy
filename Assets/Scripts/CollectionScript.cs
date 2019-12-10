using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{
    public string student1 = "Geronimo";
    public string student2 = "Jose";
    public string student3 = "Pedro";

    
    //ARRAY
    public string[] students =  new string[] {"Geronimo", "Jose", "Pedro"};
    public string[] familyNames = new string[3]; //Se crea una lista que contiene 3 lugares de datos
    

    //LIST
    public List<string> studentNames = new List<string>();

    //ARRAYLIST
    public ArrayList inventario = new ArrayList();

    //HASHTABLE
    public Hashtable personDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        // "Add" agrega elementos
        studentNames.Add("Geronimo");
        studentNames.Add("Jose");
        studentNames.Add("Pedro");
        studentNames.Add("Carla");

        //"Remove" elimina elementos
        studentNames.Remove("Pedro");

        //"Cointains" nos indica si la lista contiene dicho elemento
        if (studentNames.Contains("Geronimo"))
        {
            studentNames.Remove("Geronimo");
        }

        //"ToArray" convierte la lista en un array
        string[] studentsNamesToArray = studentNames.ToArray();

        //"Clear" elimina todos los elementos de la lista
        //studentNames.Clear();

        Debug.Log("El primer alumno de la lista es " + studentNames[0]);
        Debug.Log("El tamaño de la lista es de " + studentNames.Count);

        //
        inventario.Add(7);
        inventario.Add("Pablo");
        inventario.Add(GameObject.FindGameObjectsWithTag("Player"));

        Debug.Log(inventario[1].GetType());
        Debug.Log(inventario[2].GetType());

        //Agregar datos en HASHABLE
        personDetails.Add("firstName", "Pablo");
        personDetails.Add("lastName", "Arancibia");
        personDetails.Add("age", "29");
        personDetails.Add("gender", "male");

        
                      //casting: sirve para confirmar manualmente el tipo de dato
        string name = (string)personDetails["firstName"];
        int age = (int)personDetails["age"];

        Debug.Log(name);
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
