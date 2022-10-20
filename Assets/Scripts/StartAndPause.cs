using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndPause : MonoBehaviour
{

   //int Pause = Time.timeScale = 0; I'm going to instantiate these variables to 

   //Start = 


    // Start is called before the first frame update
    void StartAndPause()
    {
        if(Input.GetKeyDown("S") && Time.timeScale == 0)
        {
            Time.timeScale == 1;
        }
        else if(Input.GetKeyDown("P") && Time.timeScale == 1) {
            Time.timeScale == 0;
        }

        else {
            print("Do Nothing");
        }
        //if press p and time scale = 0
        //
    }




}
