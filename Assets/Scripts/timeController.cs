using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeController : MonoBehaviour
{
    // [SerializeField] float tiempoJuego;

    // [SerializeField] GameObject panelGameOver;
    // [SerializeField] Text tiempoRestante;

    // private void Update()
    // {
    //     tiempoJuego -= Time.deltaTime;
    //     tiempoRestante.text = tiempoJuego.ToString();

    //     if(tiempoJuego <= 0)
    //     {
    //         if(panelGameOver.activeSelf == false)
    //         {
    //             panelGameOver.setActive(true);
    //         }
    //     }
    // }

    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;
    
    private float restante;
    private bool enmarcha;
  
    private void Awake()
    {
        restante = (min * 60) +  seg; 
        enmarcha = true;
    }

    void Update()
    {
        if(enmarcha)
        {
            restante -= Time.deltaTime;

            int tempomin = Mathf.FloorToInt(restante / 60);
            int temposeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempomin, temposeg); 
        }
    }
    
}
