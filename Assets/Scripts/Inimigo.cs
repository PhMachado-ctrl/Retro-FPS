using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidadeInimigo;
    public Transform[] pontosParaCaminhar;
    public int pontoAtual;

    public bool inimigoEstaVivo;
    public bool inimigoPodeAndar;
    public float tempoEntrePontos;
    public float tempoAtual;

    // Start is called before the first frame update
    void Start()
    {
        inimigoEstaVivo = true;
        inimigoPodeAndar = true;
        
        //inimigo começa o ponto 0
        transform.position = pontosParaCaminhar[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarDoInimigo();
    }

    //Movimentação do Inimigo
    private void MovimentarDoInimigo()
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
                    EsperarAntesDeCaminhar();
                }
                //.lenght verifica se chegou no ponto maximo
                if(pontoAtual == pontosParaCaminhar.Length)
                {
                    pontoAtual = 0; //Faz o inimigo voltar para o primeiro ponto
                }
            }
        }
    }

    private void EsperarAntesDeCaminhar()
    {
        //inimigoPodeAndar = false;
        tempoAtual -= Time.deltaTime; //Diminui em 1 o tempo atual a cada um segundo

        if (tempoAtual <= 0)
        {
            inimigoPodeAndar = true;
            pontoAtual++;
            tempoAtual = tempoEntrePontos;
        }
    }
}
