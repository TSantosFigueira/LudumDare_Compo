using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPool : MonoBehaviour {

    public static ObjectsPool sharedInstance;   

    public GameObject objectToPool;         
    public List<GameObject> pooledObjects;  
    public int amountToPool;                

    private void Awake()
    {
        sharedInstance = this;
    }

    void Start () {
        fillPool();        
	}
	
    public GameObject getBullet ()
    {
        if (pooledObjects.Count == 0) fillPool();
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }
        return null;
    }

    void fillPool()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool, gameObject.transform);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
}
