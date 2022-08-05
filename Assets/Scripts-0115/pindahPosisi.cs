using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pindahPosisi : MonoBehaviour
{

    public GameObject prefabs1;
    public GameObject prefabs2;

    public Vector3 tempPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Swap()
    {
        tempPosition = prefabs1.transform.position;

        prefabs1.transform.position = prefabs2.transform.position;

        prefabs2.transform.position = tempPosition;
    }
}
