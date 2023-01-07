using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    

    // Update is called once per frame
    void Update()
    {
        //I am reaching for the 'transform' section of the object the script is attached to and grabbing the 'Rotate' property.
        //'transform' is a class in Unity.
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
