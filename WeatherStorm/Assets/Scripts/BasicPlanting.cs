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
    private GameObject inventoryManager;
    private int plantSeeds;
    
    public  PlantGrowing[] plantPrefabs;

    void Start()
    {
        inventoryManager =GameObject.Find("InventoryManager");
        
    }

    private void OnMouseDown()
    {
        //find out how many seeds are available 
        plantSeeds = inventoryManager.GetComponent<InventoryManager>().plantHarvested;
        if (plantSeeds >= 1)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit raycastHit = new RaycastHit();

            if (Physics.Raycast(ray, out raycastHit))
            {
                craftTargetVector = raycastHit.point;
            }

            if (plantPrefabs.Length >= 0)
            {
                PlantGrowing prefab = plantPrefabs[Random.Range(0, plantPrefabs.Length)];
                PlantGrowing spawn = prefab.GetPooledInstance<PlantGrowing>();

                spawn.transform.position = craftTargetVector;
            }
            inventoryManager.GetComponent<InventoryManager>().PlantSeeds();
        }

        // GameObject newPlant = Instantiate(Resources.Load<GameObject>("Prefabs/Plant"), craftTargetVector,
        //Quaternion.identity, craftedObject.transform);


    }
    
    //create function to ReturnToPool();


}
