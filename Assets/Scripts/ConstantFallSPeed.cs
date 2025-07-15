using UnityEngine;

public class ConstantFallSPeed : MonoBehaviour
{

    public float fallSpeed = 5f;
    public Transform Arrow;


    // Update is called once per frame
    void Update()
    {
        Arrow.position += Vector3.down * fallSpeed * Time.deltaTime;
     }
}
