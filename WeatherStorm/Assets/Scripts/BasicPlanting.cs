using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlanting : MonoBehaviour
{
    //public GameObject Ground;

    private Vector3 craftTargetVector;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit raycastHit = new RaycastHit();

        if (Physics.Raycast(ray, out raycastHit))
        {
            craftTargetVector = raycastHit.point; 
        }

        GameObject newPlant = Instantiate(Resources.Load<GameObject>("Prefabs/Plant"), craftTargetVector,
            Quaternion.identity);
    }
}
