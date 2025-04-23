using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public bool kitMedico;
    public bool municao;
    public bool chaveDourada;
    public bool chavePrata;

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
            if(kitMedico = true)
            {

            }

            if(municao == true)
            {

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
