using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private float movimiento;
    public bool piso = false;
    private bool mirarDerecha = true; 
    public Rigidbody2D rigid;
    [SerializeField] float velocidad;
    [SerializeField] float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento horizontal
        movimiento = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2(movimiento * velocidad, rigid.velocity.y);
    }

    void FixedUpdate()
    {
        //Salto
        if(Input.GetButtonDown("Jump") && piso)
        {
            rigid.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
    }

    //Validar si está tocando piso
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Piso")
        {
            piso = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collisionpiso)
    {
        if(collisionpiso.gameObject.tag=="Piso")
        {
            piso= false;
        }
    }

    //private void Girar(float movimiento)
    // {
    //     if((mirarDerecha = true && movimiento < 0) || (mirarDerecha = false && movimiento > 0))
    //     {
    //             mirarDerecha = !mirarDerecha;
    //             transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    //     }
    // }
}
