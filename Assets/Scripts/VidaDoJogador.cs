using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{
    public int vidaMaxima;
    public int vidaAtual;

    public Text textoVidaJogador;

    // Start is called before the first frame update
    void Start()
    {
        textoVidaJogador.text = "VIDA\n" + vidaAtual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucouJogador(int danoRecebido)
    {
        if (GameManager.instance.JogadorEstaVivo == true)
        {
            vidaAtual -= danoRecebido;
            textoVidaJogador.text = "VIDA\n" + vidaAtual;
            if (vidaAtual <= 0)
            {
                GameManager.instance.GameOver();
            }
        }
    }

    //METODO PUBLICO PARA GANHAR VIDA.
    public void GanharVida(vidaRecebida)
    {
        //SE A SOMA DA VIDAATIAL EA VIDARECEVIDA FOR ENOR QUE O MAXIMO FAÇA.
        if(vidaAtual + vidaRecebida < vidaMaxima)
        {
            //ADCIONA A VIDA RECEBIDA NA VIDA ATUAL.
            vidaAtual += vidaRecebida;
        }
        else
        {
            //SE NÃO VIDA ATUAL VAI SER IGUAL A VIDA MAXIMA
            vidaAtual = vidaMaxima;
        }
        textoVidaJogador.text = "VIDA\n" + vidaAtual;
    }
}
