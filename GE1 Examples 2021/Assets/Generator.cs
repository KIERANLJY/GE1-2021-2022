using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject prefab;
    public float radius = 1;
    public int points = 6;
    public int cirNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0 ; j < cirNum ; j ++)
        {
            float theta  = (Mathf.PI * 2.0f) / (float) points;
            for (int i = 0 ; i < points ; i ++)
            {
                float angle = theta * i;
                Vector3 position = new Vector3(
                    Mathf.Sin(angle) * radius,
                    Mathf.Cos(angle) * radius,
                    0
                );
                Debug.Log(angle);
                Debug.Log(position);
                GameObject obj = GameObject.Instantiate(prefab, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
            radius ++;
            points += 6;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
