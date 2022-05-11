using UnityEngine;

public class Respawn : MonoBehaviour {
	public float outOfBoundsY = -20;
	public Vector3 respawnLocation;
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y <= outOfBoundsY) {
			transform.position = respawnLocation;
		}
	}
}