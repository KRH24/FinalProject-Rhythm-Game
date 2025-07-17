using UnityEngine;

public class DestroyArrow : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {

            Destroy(other.gameObject);
        }



    }
}
