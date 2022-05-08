using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public LevelPiece[] levelPieces;
    public Transform _camera;
    public int drawDistance;

    public float pieceLength;

    private void Start() {
        
        for (int i = 0; i < drawDistance; i++) {

            GameObject newLevelPiece = Instantiate(levelPieces[0].prefab, new Vector3(0f, 0f, pieceLength * i), Quantum.identity);
        }
    }
    
}

[System.Serializable]
public class LevelPiece {

    public string name;
    public GameObject prefab;
    public int probability = 1;

}
