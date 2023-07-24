using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public int damage;
    
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D Objetocollision)
    {
        if(Objetocollision.CompareTag("Player"))
        {
            Objetocollision.gameObject.GetComponent<Jugador>().RecibirImpacto(damage);
            //Destroy(this.gameObject); No me funciono :(
        }
    }
}
