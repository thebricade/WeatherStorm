using System.Collections;
using System.Collections.Generic;
using UnityEditor.Graphing;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private PooledObjects thePooledObjects;

    List<PooledObjects> availableObjects = new List<PooledObjects>();

    public static ObjectPool GetPool(PooledObjects prefab)
    {
        GameObject obj;
        ObjectPool pool;
        obj = GameObject.Find(prefab.name + " Pool");
        if (obj)
        {
            pool = obj.GetComponent<ObjectPool>();
            if (pool)
            {
                return pool; 
            }
        }
        obj = new GameObject(prefab.name + "Pool");
        DontDestroyOnLoad(obj);
        pool = obj.AddComponent<ObjectPool>();
        pool.thePooledObjects = prefab;
        return pool;
    }

    public PooledObjects GetObject()
    {
        PooledObjects obj;
        int lastAvailableIndex = availableObjects.Count - 1;
        if (lastAvailableIndex >= 0)
        {
            obj = availableObjects[lastAvailableIndex];
            availableObjects.RemoveAt(lastAvailableIndex);
            obj.gameObject.SetActive(true);
        }
        else
        {
            obj = Instantiate<PooledObjects>(thePooledObjects);
            obj.transform.SetParent(transform,false);
            obj.Pool = this; // PooledObj script
        }
        return obj;
    }

    public void AddObject(PooledObjects obj)
    {
        obj.gameObject.SetActive(false);
        availableObjects.Add(obj);
    }
    
}
