using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScreens : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // Check the number of monitors connected.
        if (Display.displays.Length > 1)
            // Activate the display 1 (second monitor connected to the system).
            Display.displays[1].Activate();        
    }
    
}
