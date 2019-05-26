using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;


public class ControlSun : MonoBehaviour
{
    //Range for min/max values of variable
    [Range(-10f, 10f)] 
    public float sunRotationSpeed_x, sunRotationSpeed_y;

    public GameObject Sun, Moon;

    private float sunDipped_Y, moonDipped_Y;
    
    // Start is called before the first frame update
    void Start()
    {
        Moon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //the sun & moon will rotate               
        Sun.transform.Rotate(sunRotationSpeed_x*Time.deltaTime, sunRotationSpeed_y*Time.deltaTime,0);
        Moon.transform.Rotate(sunRotationSpeed_x*Time.deltaTime, sunRotationSpeed_y*Time.deltaTime,0);
        //know when they have dipped beyond the horizon to set the other active; 
       
        
        if (Sun.transform.rotation.x> -7)
        {
            turnOnMoon();
        }
        
        if (Moon.transform.rotation.x > 70)
        {
            Debug.Log("Moon should set");
        }

    }

    void turnOnMoon()
    {
      
    }

    void turnOnSun()
    {
        Sun.SetActive(false);
    }
}
