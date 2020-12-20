using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerSpawner : MonoBehaviour
{
    GameObject gameDirector; 
    public GameObject Prefab; 
    float span = 5.0f; // time for new cat 
    float delta = 0; 
    int catIdx; // Start is called before the first frame update 
    void Start() { 
        this.gameDirector = GameObject.Find("gameDirector"); 
    } // Update is called once per frame 
    void Update()
    {
        this.delta += Time.deltaTime;
       // if (this.delta > span && gameDirector.GetComponent().emptySeatCnt > 0)
        {
            this.delta = 0;
            GameObject go = Instantiate(Prefab) as GameObject;
            go.transform.position = new Vector3(1.6f, 2.2f, 0);
        }
    }
}
