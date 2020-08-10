using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


        int Add(int a, int b, int c){
                int d=a+b+c;
                return d;
        } 
        	// Use this for initialization
        void Start () {
                int num = Add (3,6,10);
                 Debug.Log(num); 
        }                      
	// Update is called once per frame
	void Update () {
		
	}
}
                 