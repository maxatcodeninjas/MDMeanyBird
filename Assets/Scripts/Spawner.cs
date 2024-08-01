using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spikes;
    public float height;
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        spikes.transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }

    void InstantiateObjects(){
        Instantiate(spikes, spikes.transform.position, spikes.transform.rotation);
    }
}
