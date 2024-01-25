using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorPrefab;
    private bool activated;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
        {
            DoorPrefab.GetComponent<MovePlanet>().Down();
            activated = true;
            Lights();
        }
    }
    private void Lights()
    {
    if(activated)
        {
            StartCoroutine(Lighte(3f));
        }
    }

    private IEnumerator Lighte(float time) 
    {
        if (activated)
        {
            yield return new WaitForSeconds(time);
            light1.SetActive(true);
            yield return new WaitForSeconds(time);
            light2.SetActive(true);
            yield return new WaitForSeconds(time);
            light3.SetActive(true);
            yield return new WaitForSeconds(time);
            light4.SetActive(true);
            activated = false;
        }
    }
}
