using UnityEngine;

public class prota : MonoBehaviour
{
    public Transform protaTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float novox = 0;
        float novoy = protaTransform.position.y;
        float novoz = protaTransform.position.z;

        protaTransform.position = new Vector3(novox, novoy, novoz);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
