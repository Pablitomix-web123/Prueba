using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumPool : MonoBehaviour
{
    public int columPoolSize = 5;
    public GameObject columPrefab;
    public float spawnRate;
    public float columMin = -1.4f;
    public float columMax = 1.3f;
    
    private float spawnXPosition=10f;
    private GameObject[] colums;
    private Vector2 objectjPoolPosition = new Vector2(-14, 0);
    private float timeSinceLastSpawned;
    private int curretColum;


    // Start is called before the first frame update
    void Start()

    {
        colums = new GameObject[columPoolSize];
        for (int i = 0; i < columPoolSize; i++)
        {
            colums[i] = Instantiate(columPrefab,objectjPoolPosition,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (!GameControler.Instance.gameOver && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columMin, columMax);
            colums[curretColum].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            curretColum++;
            if (curretColum >= columPoolSize)
            {
                curretColum = 0;
            }
        }
    }
}
