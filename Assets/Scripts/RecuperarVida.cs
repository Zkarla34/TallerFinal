using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarVida : MonoBehaviour
{

    [SerializeField] int ammount;
    public GameObject crearCura;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Jugador>().CurarVida(ammount);
        }
    }
}
