using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeToDestruction;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DestroyObject", timeToDestruction);
    }

    void DestroyObject(){
        Destroy(gameObject);
    }
}

