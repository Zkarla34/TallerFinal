using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarItem : MonoBehaviour
{
    [SerializeField] int ammount;
    
    //Colecionar items 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ScoreManager.AddScore(ammount);
            Destroy(this.gameObject);
        }
        
    }
}
