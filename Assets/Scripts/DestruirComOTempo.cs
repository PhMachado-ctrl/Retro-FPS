using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirComOTempo : MonoBehaviour
{
    public float tempoDeVida;
    // Start is called before the first frame update
    void Start()
    {
        // Destrui o proprio objeto que estiver com o codigo depois de X tempo
        Destroy(this.gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
