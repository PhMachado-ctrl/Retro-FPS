using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public Rigidbody2D oRigibody2D; //Armazena o corpo fsico do Jogador
    
    public float velocidadeDoJogador; //Armazena a velocidade de movimento do jogador como um valor flutuante.

    private Vector2 comandosDoJogador; //Armazena o valor X e Y

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    //Metodo de Movimento do jogador
    private void MovimentacaoDoJogador()
    {
        //Adiciona na variavel controle Valor na Horizontal(eixo X teclas A e D) e valor na vertical(eixo Y teclas W e S) 
        //Input.GetAxis: Valor de entrada quando preciona um botão
        comandosDoJogador = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Variaveis tipo Vector 3 armazenam Posições X, Y, Z
        // Transform.up serve para acessar o eixo que vai para cima que visão do personagem é para esquerda e direita
        Vector3 movimentoHorizontal = transform.up * comandosDoJogador.x;
        // Transform.up serve para acessar o eixo que vai para direito que visão do personagem é para cima e para Baixo
        Vector3 movimentoVertical = transform.right * comandosDoJogador.y;
        //Aplica velocidade ao corpo do Player
        oRigibody2D.velocity = (movimentoHorizontal + movimentoVertical) * velocidadeDoJogador;
    }
}