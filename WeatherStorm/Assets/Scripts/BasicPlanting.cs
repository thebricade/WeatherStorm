using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;


public class BasicPlanting : MonoBehaviour 
{
    //public GameObject Ground;
    public Rigidbody Body { get; private set; }


    private Vector3 craftTargetVector;
    private Vector3 flowerLocation;
    public GameObject craftedObject;

    public Plants[] plantPrefabs;



    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit raycastHit = new RaycastHit();

        if (Physics.Raycast(ray, out raycastHit))
        {
            craftTargetVector = raycastHit.point; 
        }

        Plants prefab = plantPrefabs[Random.Range(0, plantPrefabs.Length)];
        Plants spawn = prefab.GetPooledInstance<Plants>();

        spawn.transform.position = craftTargetVector;

        // GameObject newPlant = Instantiate(Resources.Load<GameObject>("Prefabs/Plant"), craftTargetVector,
        //Quaternion.identity, craftedObject.transform);


    }
    
    //create function to ReturnToPool();


}
