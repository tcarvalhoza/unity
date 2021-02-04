using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    //o som é um prefab e o prefab é um GameObject
    public GameObject somDoBloco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //método de colisão do Unity
    private void OnCollisionEnter2D(Collision2D other)
    {
        //verificar o objeto que colidiu
        //especificamos a Tag criada para o objeto que fará a colisão
        if(other.gameObject.CompareTag("Bola"))
        {
            //instancia o prefab somDoBloco e em seguida passamos a posição
            Instantiate(somDoBloco, transform.position, transform.rotation);
            //Destroi o gameObject especificado
            Destroy(this.gameObject);
        }
    }
}
