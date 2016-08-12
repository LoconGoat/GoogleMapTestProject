using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

    public Vector3[] positions;
    public float interval = 5f; // public float limitSec = 5f * 60f; // interwał = 5 minut
    public float actual = 0f;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	//void Update () {
 //       if (actual > interval)
 //       {
 //           int randomNumber = Random.Range(0, positions.Length);
 //           transform.position = positions[randomNumber];
 //           actual = 0f;
 //       }
 //       actual += Time.deltaTime;
 //   }
}
