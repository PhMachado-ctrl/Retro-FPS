using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public bool kitMedico;
    public bool municao;
    public bool chaveDourada;
    public bool chavePrata;

    public int vidaParaDar;
    public int municaoParaDar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //SE FOR KITMEDICO FAÇA.
            if(kitMedico = true)
            {
                other.gameObject.GetComponent<VidaDoJogador>().GanharVida(vidaParaDar);
            }
            
            //SE FOR MUNIÇÃO FAÇA.
            if(municao == true)
            {
                //PEGA O COMPONENTE DE QUE COLIDIU E CHAMA O MÉTODO
                other.gameObject.GetComponent<AtaqueDoJogador>().GanharMunicao(municaoParaDar);
            }

            if(chaveDourada == true)
            {
                
            }

            if(chavePrata == true)
            {

            }

            Destroy(this.gameObject);
        }
    }
}
