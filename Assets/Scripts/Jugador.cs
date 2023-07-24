using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] int vidaMaxima;
    public GameObject activeAndDesactive;
    [SerializeField] float tiempoApareceCura;
     
    public void Start()
    {
        ScoreManager.SetValues(0,5);
    }

    public void RecibirImpacto(int impacto)
    {
       
        if(vida - impacto > 0)
        {
            vida -= impacto;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void CurarVida(int ammount)
    {
        if(vida + ammount >= vidaMaxima)
        {
            vida = vidaMaxima;
        }
        else
        {
            vida += ammount;
            StartCoroutine(ActivarCura());

        }  
    }  

    IEnumerator ActivarCura() 
    {
        activeAndDesactive.SetActive(false);
        yield return new WaitForSeconds(tiempoApareceCura);
        activeAndDesactive.SetActive(true);
    }
}
