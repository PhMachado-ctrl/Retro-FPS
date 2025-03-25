using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidadeInimigo;
    public Transform[] pontosParaCaminhar;
    public int pontoAtual;

    private bool inimigoEstaVivo;
    private bool inimigoPodeAndar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Movimentação do Inimigo
    private void MovimentoDoInimigo()
    {
        if(inimigoEstaVivo)
        {
            if(inimigoPodeAndar)
            {
                //Vector2.MoveTowards move de um ponto ao outro
                transform.position = Vector2.MoveTowards(transform.position, pontosParaCaminhar[pontoAtual].transform.position, velocidadeInimigo * Time.deltaTime);

                //Identifica se o inimigo chegou no ponto
                if (transform.position.y == pontosParaCaminhar[pontoAtual].position.y)
                {
                    pontoAtual++;
                }
                //.lenght verifica se chegou no ponto maximo
                if(pontoAtual == pontosParaCaminhar.Length)
                {
                    pontoAtual = 0;
                }
            }
        }
    }
}
