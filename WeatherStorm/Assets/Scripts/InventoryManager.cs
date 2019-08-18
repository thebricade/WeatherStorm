using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class InventoryManager : MonoBehaviour
{
    public GameObject ground;

    private int plantsInHavest;
    
    //public static Plants[] grown;
    public int plantHarvested;
    
    // Start is called before the first frame update
    void Start()
    {
        plantHarvested = 2;
    }

    // Update is called once per frame
    void Update()
    {
//        grownPlants = BasicPlanting.plantPrefabs.Length;
        //grownPlants = ground.GetComponent<PlantGrowing>().harvestPlant;
        print("Plants harvested " +plantHarvested);
    }

    public void HavestPlant()
    {
        plantHarvested++;
        //plantHarvested = gameObject.GetComponent<ObjectPool>().availableObjects.Count;
       // print(plantHarvested);
    }

    public void PlantSeeds()
    {
        plantHarvested--;
    }
}
