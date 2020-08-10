using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss { 
        private int mp =53; 
        private int damage = 5;
        //魔法攻撃用の関数
        public void Magic(){

                if(mp < 5) {
                Debug.Log("MPが足りないため魔法が使えない。");
        }  
                                            
               else{
                   //残りmpを減らす
　　　　　　　　　　this.mp -= damage;
                Debug.Log("魔法攻撃をした。残りMPは"+mp);  
        }    
                     }
}

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
               Boss firstboss = new Boss();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
              firstboss. Magic ();
      	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
