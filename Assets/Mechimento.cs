using UnityEngine;

public class Mechimento : MonoBehaviour
{
    bool pulando = false;
    int inicioPulo = 0;
    int frameAtual = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        frameAtual = frameAtual + 1;
    //Faz o boneco andar pra frente
        if (Input.GetKey("d"))
            {
            this.transform.Translate(0.05f, 0, 0);
            }

        if (Input.GetKey("a"))
            {
            this.transform.Translate(-0.05f, 0, 0);
            }

        if (Input.GetKey("space") && pulando == false && Physics.CheckSphere(transform.position, 0.05f))
            {
                pulando = true;
                inicioPulo = frameAtual;
            }
        if (pulando && frameAtual - inicioPulo > 0.05f)
            {
                pulando = false;
            }
        if (pulando)
            {
                this.transform.Translate(0, 0.05f, 0);
            }
    
        if !Physics.Checksphere(transform.position, 1f)
        {
            transform.Translate(0, -0.10f, 0);
        }
    
    }


}

//ESSE NEGOCIO NAO VOLTA PRO CHAO RRRRRRRRRRRRAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHH



