using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //'transform' means I am accessing the transform section of the game object. I have moved this script onto the object within Unity - that's how a particular
        //script connects to the particular object.
        //'Translate' needs me to tell it where I want it to go on the x, y and z. But 'Translate' needs to see a number. It won't change the values into the ones
        //I provide here, it will add the provided values to the existing ones. When this is put within Update(), it is performed every single frame. If I want to
        //utilize floating point numbers, I need to put an 'f' behind it. 
        transform.Translate(0.01f, 0, 0);
    }
}
