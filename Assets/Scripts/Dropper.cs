using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //At the start of the game, I want my bomb invisible, so I need to have the MeshRenderer disabled. If I am going
        //to access the MeshRenderer multiple times, I can store that reference in a variable. Instead of writing
        //'GetComponent<MeshRenderer>().enabled = false' every time, I declare a variable of the MeshRenderer type
        //('renderer' above) and define it once below. Now I can refer to the variable instead.
        //This process is called 'caching a reference'. It's a technique of storing frequently used data in memory so that
        //it can be easily accessed when needed.
        renderer = GetComponent<MeshRenderer>(); 
        renderer.enabled = false;

        //To start with, the gravity is to not apply to my bomb. Otherwise it will fall upon the start of the game.
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //'Time.time' holds the value of how much time has elapsed since the start of the game.
        //The bomb has had a Rigidbody component added to it and Use Gravity disabled by default. Since the MeshRenderer is also
        //initially disabled, the bomb is not visible to the player until it starts falling. If 3 seconds have passed, I need to
        //to reach for the cached properties and enable them to make my bomb appear and fall! 
        if(Time.time > timeToWait){
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
