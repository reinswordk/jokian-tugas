using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAnimasi : MonoBehaviour
{
    public GameObject objek;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = objek.GetComponent<Animator>();
    }
    public void AnimasiStop()
    {
        Destroy(anim);
    }

}
    