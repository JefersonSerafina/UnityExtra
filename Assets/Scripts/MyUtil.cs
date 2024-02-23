using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyUtil
{
    public static T GetRandomItem<T>(this List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            return default(T);
        }

        return list[Random.Range(0, list.Count)];
    }
}
