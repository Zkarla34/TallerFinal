using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] GameObject municion;
    [SerializeField] Transform iniciodisparo;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Disparo"))
        {
            shot();
        }
    }

    void shot()
    {
        Instantiate(municion, iniciodisparo.position, iniciodisparo.rotation);
    }
}
