using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObjects : MonoBehaviour
{
   [System.NonSerialized] 
   ObjectPool poolInstanceForPrefab;

   public T GetPooledInstance<T>() where T : PooledObjects
   {
      if (!poolInstanceForPrefab)
      {
         poolInstanceForPrefab = ObjectPool.GetPool(this);
      }

      return (T) poolInstanceForPrefab.GetObject();
   }
   
   public ObjectPool Pool { get; set; }

   public void ReturnToPool()
   {
      
      if (Pool)
      {
         Pool.AddObject(this);
      }
      else
      {
         Debug.Log("I didn't do something right");
         Destroy(gameObject);
      }
   }
}
