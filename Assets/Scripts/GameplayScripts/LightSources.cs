using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSources : MonoBehaviour
{
    public GameObject lighterOb;
    public GameObject flame;
    public GameObject lightText;

    public bool unlit;
    public bool inReach;
    // Start is called before the first frame update
    void Start()
    {
        unlit = true;
        flame.SetActive(false);
        lightText.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" && unlit)
        {
            inReach = true;
            lightText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach" && unlit)
        {
            inReach = false;
            lightText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (lighterOb.activeInHierarchy && inReach && unlit && Input.GetButtonDown("Interact"))
        {
            flame.SetActive(true);
            lightText.SetActive(false);
            unlit = false;
        }
    }
}
