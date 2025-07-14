using UnityEngine;
using UnityEngine.UI; //utilized for UI Image

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR; 
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>(); //Get the Image on the button
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage; //Change sprite when key is pressed
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage; //Change back when released
        }
    }
}
