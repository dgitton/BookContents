using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chocolate : MonoBehaviour
{
    public int valeurDeChocolate=0;
    // Start is called before the first frame update
    void Start()
    {
        print("Start de Chocolate, valeur " + valeurDeChocolate);
    }

    // Update is called once per frame
    void Update()
    {
        valeurDeChocolate++;
        //print("Update de Chocolate, valeur " + valeurDeChocolate);

    }
}
