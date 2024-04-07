using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sectionArray;
    public int zpos = 0;
    public bool creatingSection = false;
    public int secNum;
    //public GameObject[] sectionArray;
    bool first = true;
    private void Start()
    {

        
    }


// Update is called once per frame
void Update()
    {
        if (first)
        {
            StartCoroutine(GenerateSection(true));

            first = false;  
        }
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection(false));
        }
    }
    IEnumerator GenerateSection(bool first)
    {
        if (!first)
        {
            secNum = Random.Range(0, 3);
        }
        else
        {
            secNum = 0;
            
        }

        Instantiate(sectionArray[secNum], new Vector3(0,0,zpos), Quaternion.identity);
        zpos += 40;
        yield return new WaitForSeconds(4);
        creatingSection=false;
    }

    
}
