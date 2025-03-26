using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilDoInimigo : MonoBehaviour
{
    public float velocidadeDoProjetil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vai reto, direção que está olhando
        transform.Translate(Vector3.forward * velocidadeDoProjetil * Time.deltaTime);
    } 
}
