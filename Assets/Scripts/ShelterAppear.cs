using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterAppear : MonoBehaviour
{

    public GameObject shelter;
    // Start is called before the first frame update
    void Start()
    {
        shelter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            shelter.SetActive(true);
            Debug.Log("Yay");
        }
    }
}
