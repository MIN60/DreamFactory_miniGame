using UnityEngine;
using System.Collections.Generic;

public class RandomItem : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] prefab;
    void Start()
    {
        List<Transform> temp_list = new List<Transform>(spawnPoints);
        for (int i = 0; i < prefab.Length; i++)
        {
            int targetIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(prefab[i], spawnPoints[targetIndex].position, spawnPoints[targetIndex].rotation);

            temp_list.Remove(temp_list[targetIndex]);
        }
    }
    void Update()
    {


    }
}
