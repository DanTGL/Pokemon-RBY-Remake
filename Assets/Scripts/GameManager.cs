using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private Move[] moves;

    void Awake() {
        TextAsset movesAsset = Resources.Load<TextAsset>("Data/moves");

        moves = JsonUtility.FromJson<Move[]>(movesAsset.text);
    }
    
}
