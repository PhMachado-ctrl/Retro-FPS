using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDoJogador : MonoBehaviour
{
    public Animator animatorDaArma;
    public GameObject efeitoDeImpacto; //Armazena o pre fab do game object
    public Camera cameradoJogo; //Armazena o objeto da Camera
    public int maxMunicao; //Maximo de munição que pode carregar.
    public int AtualMunicao; //Quantidade atual de munição.

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Deixa mouse travado dentro da tla do jogo.
        Cursor.visible = false; //Cursor invisivel.
        
    }

    // Update is called once per frame
    void Update()
    {
        Atirar();
    }

    private void Atirar()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(AtualMunicao > 0)
            {
                //Cria um raio no meio da tela.
                Ray raio = cameradoJogo.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                RaycastHit localDeAcerto; 

                //Se a parte fisica acerta algo.
                // out coloca o valor de raio em local de acerto
                if(Physics.Raycast(raio, out localDeAcerto))
                {
                    //Instancia o efeito Impacto na localzação que o racast acertou
                    Instantiate(efeitoDeImpacto, localDeAcerto.point, localDeAcerto.transform.rotation);
                    Debug.Log("Você está olhando: " + localDeAcerto.transform.name);
                }
                else
                {
                    Debug.Log("Você está olhando nada.");
                }
            }
            else
            {
                Debug.Log("Sem Munição");
            }
            AtualMunicao--;
            animatorDaArma.SetTrigger("Arma Atirando");
        }
    }
}
