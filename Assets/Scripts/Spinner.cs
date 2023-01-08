using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // [SerializeField] float xAngle = 0;
    // [SerializeField] float yAngle = 0.5f;
    // [SerializeField] float zAngle = 0;
    

    // Update is called once per frame
    void Update()
    {
        //I am reaching for the 'transform' section of the object the script is attached to and grabbing the 'Rotate' property.
        //'transform' is a class in Unity.
        //Referring to the variables above doesn't work, upon the start of the game, the Y remains unchanged. It works if I hardcode
        //the values.
        transform.Rotate(0, 0.5f, 0);
    }
}
