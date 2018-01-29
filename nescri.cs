using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nescri : MonoBehaviour {

public int direction=0;
public int tranq;

   public Vector2 jumpforce = new Vector2 (300,0);
 public Vector2 axis = new Vector2 (300,0);
 Rigidbody2D rB2D;

public int i=0;
	// Use this for initialization
	void Start () {
		 rB2D = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

if (Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Main Camera").transform.position.x < 500 ) 
  Application.Quit();
 
 else	if	(Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Main Camera").transform.position.x < 1200 )

{
direction=1; tranq=40;
rB2D.velocity=Vector2.zero;
rB2D.AddForce(axis);
i++;

}
 else	if	(Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Main Camera").transform.position.x < 1800 )

{
direction=1; tranq=640;
rB2D.velocity=Vector2.zero;
rB2D.AddForce(axis);
i++;

}





// 		if(Input.GetKeyUp("space")|| (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began))
// 		{
 
// if(i%2==0){


// rB2D.velocity=Vector2.zero;
// rB2D.AddForce(jumpforce);
// i++;
// }
// else
// {
// rB2D.velocity=Vector2.zero;
// rB2D.AddForce(axis);
// i++;


// }

// }

//Vector2 screenPosition= Camera.main.WorldToScreenPoint(transform.position);

//Debug.Log(GameObject.Find("Main Camera").transform.position.x);


if(direction==0)
{

if(GameObject.Find("Main Camera").transform.position.x >tranq) 
{

rB2D.velocity=Vector2.zero;

}


}
else	



{

if(GameObject.Find("Main Camera").transform.position.x <tranq) 
{

rB2D.velocity=Vector2.zero;

}


}



}

public void sekon()
{

direction = 0;
tranq = 600;
 
if(i%2==0){


rB2D.velocity=Vector2.zero;
rB2D.AddForce(jumpforce);
i++;
}
else
{
rB2D.velocity=Vector2.zero;
rB2D.AddForce(jumpforce);
i++;




}

}


public void sekan()
{

direction=0;
tranq = 1200;
 
if(i%2==0){


rB2D.velocity=Vector2.zero;
rB2D.AddForce(jumpforce);
i++;
}
else
{
rB2D.velocity=Vector2.zero;
rB2D.AddForce(jumpforce);
i++;




}

}




		}
		
	

