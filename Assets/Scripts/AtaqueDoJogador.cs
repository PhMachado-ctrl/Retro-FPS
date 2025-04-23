using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtaqueDoJogador : MonoBehaviour
{
    public Text TextoDeMunicao;
    public Animator animatorDaArma;
    public GameObject efeitoDeImpacto; //Armazena o pre fab do game object
    public Camera cameradoJogo; //Armazena o objeto da Camera
    public int maxMunicao; //Maximo de munição que pode carregar.
    public int atualMunicao; //Quantidade atual de munição.

    public int danoCausado;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Deixa mouse travado dentro da tla do jogo.
        Cursor.visible = false; //Cursor invisivel.
        TextoDeMunicao.text = "MUNIÇÃO\n" + atualMunicao;
        
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
            if(atualMunicao > 0)
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

                    if(localDeAcerto.transform.gameObject.CompareTag("Inimigo"))
                    {
                        localDeAcerto.transform.gameObject.GetComponentInParent<Inimigo>().MachucouInimigo(danoCausado);
                    }

                }
                else
                {
                    Debug.Log("Você está olhando nada.");
                }
                atualMunicao--;
                TextoDeMunicao.text = "MUNIÇÃO\n" + atualMunicao;
                animatorDaArma.SetTrigger("Arma Atirando");
            }
            else
            {
                Debug.Log("Sem Munição");
            }
           
        }
    }

    public void GanharMunicao(int municaoParaReceber)
    {
        //SE A SOMA DA MUNICAO FOR MENOR QUE A MAXIMA FAÇA
        if (atualMunicao + municaoParaReceber < maxMunicao)
        {
           //SOME A QUANTIDADE DE MUNICAO ATUAL COM A QUE ESTÁ RECEBENDO.
           atualMunicao += municaoParaReceber; 
        }
        else
        {
            //SE A MUNICAO QUE VAI RECEBER FOR MAIOR QUE A MAXIMA A MUNICAO ATUAL SERA IGUAL A MAXIMA 
            atualMunicao = maxMunicao;
        }

        //TEXTO DE MUNICAO SERA ATUALIZADO NA TELA
        TextoDeMunicao.text = "MUNIÇÃO\n" + atualMunicao;
    }
}
