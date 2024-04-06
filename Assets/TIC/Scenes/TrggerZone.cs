using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrggerZone : MonoBehaviour
{
    public GameObject Video;
    public GameObject CanVas;
    void Start() {
          Video.GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Player")
        {
            Video.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Video.GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
        }
    }
}
