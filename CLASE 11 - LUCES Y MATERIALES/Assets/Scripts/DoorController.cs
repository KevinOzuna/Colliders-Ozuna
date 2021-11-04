using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private Vector2 xArea;
    [SerializeField] private Vector2 yArea;
    [SerializeField] private Vector2 zArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Chocando con el player");
            float xPoint = Random.Range(xArea[0], xArea[1]);
            float yPoint = Random.Range(yArea[0], yArea[1]);
            float zPoint = Random.Range(zArea[0], zArea[1]);

            transform.position = new Vector3(xPoint, yPoint, zPoint);
        }
    }
}
