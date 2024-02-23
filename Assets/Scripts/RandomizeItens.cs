using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeItens : MonoBehaviour
{
    public List<GameObject> gameObjectsToRandomize;
    private GameObject currentObject;


    private void Start()
    {
        foreach (GameObject obj in gameObjectsToRandomize)
        {
            obj.SetActive(false);
        }

        RandomizeAndSwitch();
    }

    [NaughtyAttributes.Button]
    public void RandomizeAndSwitch()
    {
        if (currentObject != null)
        {
            currentObject.SetActive(false);
        }

        currentObject = gameObjectsToRandomize.GetRandomItem();

        currentObject.SetActive(true);
    }

}
