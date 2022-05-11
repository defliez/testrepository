/*
Author: Valentino Glave
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public LevelPiece[] levelPieces;
    public Transform _camera;
    public int drawDistance;

    public float pieceLength;
    public float speed;

    Queue<GameObject> activePieces = new Queue<GameObject>();

    int currentCamStep = 0;
    int lastCamStep = 0;

    private void Start() {
        
        for (int i = 0; i < drawDistance; i++) {

            SpawnNewLevelPiece();
        }

        currentCamStep = (int)(_camera.transform.position.z / pieceLength);
        lastCamStep = currentCamStep;
    }

    private void Update() {
        _camera.transform.position = Vector3.MoveTowards(_camera.transform.position, _camera.transform.position + Vector3.forward, Time.deltaTime * speed );

        currentCamStep = (int)(_camera.transform.position.z / pieceLength);
        if(currentCamStep != lastCamStep) {

            lastCamStep = currentCamStep;
            DeSpawnLevelPiece();
            SpawnNewLevelPiece();

        }
    }

    void SpawnNewLevelPiece() {
        GameObject newLevelPiece = Instantiate(levelPieces[0].prefab, new Vector3(0f, 0f, (currentCamStep + activePieces.Count) * pieceLength), Quaternion.identity);
        activePieces.Enqueue(newLevelPiece);
    }

    void DeSpawnLevelPiece() {
        
        GameObject oldLevelPiece = activePieces.Dequeue();
        Destroy(oldLevelPiece);
    }
}

[System.Serializable]
public class LevelPiece {

    public string name;
    public GameObject prefab;
    public int probability = 1;

}
