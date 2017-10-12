using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    public GameObject ApplePrefab;
    public float speed = 1f;
    public float leftandrightedge = 10f;
    public float chanceToChangeDirections = .02f;
    public float secondsBetweenAppleDrops = 1f;
    
	// Use this for initialization
	void Start () {
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftandrightedge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftandrightedge)
        {
            speed = -Mathf.Abs(speed);
        }
        
        
	}
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
    void DropApple()
    {
        GameObject Apple = Instantiate(ApplePrefab) as GameObject;
        Apple.transform.position = transform.position;
    }
}
