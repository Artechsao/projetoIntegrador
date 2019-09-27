using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merlin : MonoBehaviour
{
    private float velocidadeHorizontal = 0.1f;
    private float velocidadeVoo = 0.1f;
    Rigidbody2D corpoMerlin;

    private void Awake()
    {
        corpoMerlin = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentoMerlin();

    }

    void movimentoMerlin()
    {
        Vector3 movimentaMerlin = new Vector3();

        float movimentoHorizontal = Input.GetAxis("Horizontal");     
        movimentaMerlin.x = movimentoHorizontal * velocidadeHorizontal;

        float movimentoVertical = Input.GetAxis("Vertical");
        if(movimentoVertical != 0)
        {
            //Altera garvidade para zero
            //Desconta pontos da magia
            
            movimentaMerlin.y = movimentoVertical * velocidadeVoo;
        }

        //Garantir que ele não vai ficar virando
        transform.Translate(movimentaMerlin);

    }
}
