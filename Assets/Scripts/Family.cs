using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{

    public Person father;
    public Person mother;
    public Person son;
    
    // Start is called before the first frame update
    void Start()
    {
        father = new Person("Anakin", "Skywalker"); //instanciar
        //Después de instanciar podemos inicializar
        father.age = 29;
        father.isMale = true;
        

        mother = new Person("Pademe", "Amidala", 28, false);
        

        father.spouse = mother;
        mother.spouse = father;

        son = new Person();
        //son.firstName = "Luke";
        //son.lastName = "Skywalker";
        son.age = 0;
        son.isMale = true;

        son.setFirstName("Luke");
        son.setLastName("Skywaler");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
