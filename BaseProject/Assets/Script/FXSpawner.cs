using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : MonoBehaviour
{

    public GameObject Fx;
    public Transform fxPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Instantiate(Fx, fxPos.position, Quaternion.identity);
        }
    }
}
