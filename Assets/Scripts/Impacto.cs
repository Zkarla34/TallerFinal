using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    [SerializeField] int cantidadImpacto;
    [SerializeField] bool darImpacto = true;
    [SerializeField] float tiempoSinImpacto;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(darImpacto)
            {
                collision.GetComponent<Jugador>().RecibirImpacto(cantidadImpacto);
                StartCoroutine(DesactivarImpacto());
            }
            
        }
    }

    IEnumerator DesactivarImpacto()
    {
        darImpacto = false;
        yield return new WaitForSeconds(tiempoSinImpacto);
        darImpacto = true;
    }
}
