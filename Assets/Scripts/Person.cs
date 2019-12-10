using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person 
{ 

    private string firstName;
    private string lastName;
    public int age;
    public bool isMale;

    public Person spouse;

    //constructor por defecto
    public Person()
    {

    }

    //Constructor que inicializa nombre y apellido
    public Person(string pFirstName, string pLastName)
    {
        this.firstName = pFirstName;
        this.lastName = pLastName;
    }

    //Constructor con todos los parametros
    public Person(string firstName, string lastName, int age, bool isMale)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.isMale = isMale;
    }

    
   
    public bool IsMarriedWith(Person otherperson)
    {
        if (spouse == null)
        {
            return false;
        }
        else
        {
            if(otherperson == this.spouse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //SETTERS Y GETTERS

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }
    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }
    public string getFirstName()
    {
        return this.firstName;
    }
    public string getLastName()
    {
        return this.lastName;
    }

}
