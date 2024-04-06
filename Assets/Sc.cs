using System.Collections;
using System.Collections.Generic;

using System.Threading;
using UnityEngine;
using UnityEngine.Video;

public class Sc : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer tv;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Avatar")
        {
            tv.Play();

        }
       
    }
   
}

