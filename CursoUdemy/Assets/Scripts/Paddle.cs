using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //quando criada variavel do tiupo public é possivel alterar seu valor na Unity
    public float velocidadeDoPaddle;

    public float xMinimo;

    public float xMaximo;

    //Roda quando o game é iniciado
    void Start()
    {
        
    }

    //é chamado a cada frame
    void Update()
    {
        MovimentoDoPaddle();
    }

    private void MovimentoDoPaddle()
    {
        //acessa a posição no componente transform
        //Vector2 passa um novo valor para X e Y
        //Mathf.Clamp limitar X entre Minimo e Maximo
        //transform.position.y mantem ele no mesmo eixo Y sem mudanças
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), transform.position.y);

        //se as setas foram acionadas
        //0.01f verifica se o botao precionado foi no eixo positivo
        if(Input.GetAxisRaw("Horizontal") > 0.01f)
        {
            //transform - Acessa as propriedados do objeto
            //translate - Modifica os valores de X, Y e Z
            //vector2 - Acessa somente X e Y
            transform.Translate(Vector2.right * velocidadeDoPaddle * Time.deltaTime);
        }

        //se as setas foram acionadas
        //-0.01f verifica se o botao precionado foi no eixo negativo
        if(Input.GetAxisRaw("Horizontal") < -0.01f)
        {
            //transform - Acessa as propriedados do objeto
            //translate - Modifica os valores de X, Y e Z
            //vector2 - Acessa somente X e Y
            transform.Translate(Vector2.left * velocidadeDoPaddle * Time.deltaTime);
        }
    }
}
