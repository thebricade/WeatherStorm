using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject ground;
    
    //public static Plants[] grown;
    public int grownPlants;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//        grownPlants = BasicPlanting.plantPrefabs.Length;
        //grownPlants = ground.GetComponent<PlantGrowing>().harvestPlant;
        print(grownPlants);
    }

    public void GrowPlant()
    {
        grownPlants++;
    }
}
