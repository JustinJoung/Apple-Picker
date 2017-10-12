using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour {
    public GameObject BasketPreFab;
    public int numBask = 3;
    public float baskBottomY = -14f;
    public float baskSpacingY = 2f;
    public List<GameObject> basklist;

	// Use this for initialization
	void Start () {
        basklist = new List<GameObject>();
		for(int i =0; i<numBask; i++)
        {
            GameObject tbasketGo = Instantiate(BasketPreFab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = baskBottomY + (baskSpacingY * i);
            tbasketGo.transform.position = pos;
            basklist.Add(tbasketGo);
        }
	}
	
	// Update is called once per frame
	void Update () {

        
	}
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach( GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
    }
  
}
