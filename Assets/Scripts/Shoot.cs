using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject Bullet;
    public float shootForce;
    public AudioSource shootSound;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
        {
           
            if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                {
                    shootSound.Play();
                    Instantiate(Bullet, shootPoint.position, shootPoint.rotation).GetComponent<Rigidbody>().AddForce(shootPoint.forward * shootForce);

                }
            }
            
        }
        
    }
}
