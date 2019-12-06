using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitResult : MonoBehaviour
{
    public GameObject Evil;
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Evil.transform.childCount == 0)
        {
            DestroyImmediate(Evil);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Evil = GameObject.Find("Evil");
            Destroy(Evil);
            Destroy(gameObject);

        }      

    }
    

}
