using UnityEngine;

public class ElevatorController : MonoBehaviour {

	public float speed;
	public float upper;
	public float lower;
	public Axis axis;
	public MoveState moveState;

	// Update is called once per frame
	void FixedUpdate () {
		if (axis.Equals(Axis.X)) {
			if (transform.position.x >= upper) {
				moveState = MoveState.ToLower;
			} else if (transform.position.x <= lower) {
				moveState = MoveState.ToUpper;
			}
		} else if (axis.Equals(Axis.Y)) {
			if (transform.position.y >= upper) {
				moveState = MoveState.ToLower;
			} else if (transform.position.y <= lower) {
				moveState = MoveState.ToUpper;
			}
		} else if (axis.Equals(Axis.Z)) {
			if (transform.position.z >= upper) {
				moveState = MoveState.ToLower;
			} else if (transform.position.z <= lower) {
				moveState = MoveState.ToUpper;
			}
		}
			
		checkMove();
	}

	private void checkMove() {
		if (axis.Equals(Axis.X)) {
			if (moveState.Equals(MoveState.ToUpper)) {
				transform.Translate(Vector3.right * speed);
			} else {
				transform.Translate(Vector3.left * speed);
			}
		} else if (axis.Equals(Axis.Y)) {
			if (moveState.Equals(MoveState.ToUpper)) {
				transform.Translate(Vector3.up * speed);
			} else {
				transform.Translate(Vector3.down * speed);
			}
		} else if (axis.Equals(Axis.Z)) {
			if (moveState.Equals(MoveState.ToUpper)) {
				transform.Translate(Vector3.forward * speed);
			} else {
				transform.Translate(Vector3.back * speed);
			}
		}
	}
}

public enum Axis {
	X, Y, Z
}
public enum MoveState {
	ToUpper, ToLower
}