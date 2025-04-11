using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool JogadorEstaVivo; //VErifica se jogador está vivo

    // Start is called before the first frame update
    void Start()
    {
        JogadorEstaVivo = true;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        JogadorEstaVivo = false;
    }
}
