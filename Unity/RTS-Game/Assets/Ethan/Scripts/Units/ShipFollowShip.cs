using UnityEngine;
using System.Collections;

public class ShipFollowShip : MonoBehaviour {

	public Transform target; 
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;
	private Transform myTransform;


	public float delay = 1.0f;
	public Transform Ammo;
	public Transform shootPoint;
	//public string floorTag = "Floor"; 


	void Awake()
	{
		myTransform = transform;
		myTransform.LookAt (target);

	}
	
	
	void Start ()
	{
		
		maxdistance = 10;
	}
	
	
	void Update ()
	{
		maxdistance = 10;
		myTransform.LookAt (target);
		myTransform = transform;
		if (Vector3.Distance (target.position, myTransform.position) > maxdistance) {
			
			// Get a direction vector from us to the target
			Vector3 dir = target.position - myTransform.position;
			
			// Normalize it so that it's a unit direction vector
			dir.Normalize ();
			
			// Move ourselves in that direction
			myTransform.position += dir * moveSpeed * Time.deltaTime;

		
		}

		if (Vector3.Distance (target.position, myTransform.position) < maxdistance) {
			StartCoroutine(Build(delay));
		}
	


}
	IEnumerator Build(float delay)
	{
		yield return new WaitForSeconds(delay);
		Instantiate(Ammo,shootPoint.position,shootPoint.rotation); 
	}

}
