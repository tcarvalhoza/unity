using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Inclui o gerenciamento de cenas

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bola"))
        {
            //carrega uma cena (especifica qual a cena vai carregar no caso a atual)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
