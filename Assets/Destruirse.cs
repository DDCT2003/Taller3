using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruirse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // Comprueba si la bala ha colisionado con un objeto que no sea ella misma
        if (!collision.gameObject.CompareTag("Bala"))
        {
            // Destruye la bala
            Destroy(gameObject);
        }
    }
}
