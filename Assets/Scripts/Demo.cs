using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Demo : MonoBehaviour
{
    public GameObject heroPrefabs;
    public Transform HeroTransform;
 
    void Start()
    {
        //Debug.Log(heroPrefabs);
        HeroTransform.position = new Vector3(2f, 3f, 0f);
        HeroTransform.localScale = new Vector3(3f, 3f, 0f);

        


        if (heroPrefabs)
        {
            var heroClone = Instantiate(heroPrefabs, new Vector3(3f, 4f, 0f), Quaternion.identity);
            //Destroy(heroClone,3f);
        }

        

        Debug.Log(HeroTransform.position);
        Debug.Log(HeroTransform.localScale);
       
    }

    
    void Update()
    {
        Debug.Log(heroPrefabs.name);

    }
}
