using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{   
    public GameObject cam;
    public GameObject player;
    //public GameObject bone;
    
    // Start is called before the first frame update
    void Start()
    {
        player.transform.rotation = cam.transform.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        //bone.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles.x, bone.transform.rotation.eulerAngles.y, bone.transform.rotation.eulerAngles.z);
        player.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles.x, cam.transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);

    }
}
