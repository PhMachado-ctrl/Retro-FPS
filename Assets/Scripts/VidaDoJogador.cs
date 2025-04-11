using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoJogador : MonoBehaviour
{
    public int vidaMaxima;
    public int vidaAtual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucouJogador(int danoRecebido)
    {
        if (GameManager.instance.JogadorEstaVivo)
        {
            vidaAtual -= danoRecebido;

            if (vidaAtual <= 0)
            {
                GameManager.instance.gameObject.GetComponent<GameManager>().GameOver();
            }
        }
    }
}
