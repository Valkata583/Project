using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 12;
    public bool creatingSection = false;
    public int secNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 12;
        yield return new WaitForSeconds(0);
        creatingSection = false;
    }
}
