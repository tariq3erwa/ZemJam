using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject spawnPosition;
    [SerializeField] float frequency;
    float timer;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > frequency)
        {
            Spawn(enemy, spawnPosition);
            timer= 0;
        }
    }

    void Spawn(GameObject enemy, GameObject position)
    {
        Instantiate(enemy, position.transform.position, Quaternion.identity);
    }
}
