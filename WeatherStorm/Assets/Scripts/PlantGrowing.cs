using System.Collections;
using System.Collections.Generic;
using UnityEditor.Graphing;
using UnityEngine;

public class PlantGrowing : PooledObjects
{
    private Vector3 initialPlantPosition;
    private GameObject inventoryManager;
    public int harvestPlant;
    
    
    // Start is called before the first frame update
    void Start()
    {
        inventoryManager =GameObject.Find("InventoryManager");
        StartCoroutine(GrowingTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GrowingTime()
    {
        yield return new WaitForSeconds(2);

        //ReturnToPool();
    }

    private void OnMouseDown()
    {
        inventoryManager.GetComponent<InventoryManager>().HavestPlant();
       // harvestPlant = gameObject.GetComponents<PooledObject<ObjectPool>>().Length; 
        //print("Number from pooled object??? "+ harvestPlant);
        ReturnToPool();
        
    }
}
