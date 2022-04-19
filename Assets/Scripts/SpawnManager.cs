using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 3.0f)
        {
            transform.position = new Vector3(Random.Range(-4.0f, 4.0f),1f, Random.Range(-4f, 0f));
            GameObject temp=Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            Destroy(temp,5f);

            time = 0;
        }

    }
}
