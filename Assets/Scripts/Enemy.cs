using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

    public abstract Pokemon GetPokemon();

    public abstract Move ChooseMove(Pokemon enemy);

    public static int GetRandomMoveIndex() {
        int rand = UnityEngine.Random.Range(0, 255);

        if (rand < 0x3F) {
            return 0;
        } else if (rand < 0x7E) {
            return 1;
        } else if (rand < 0xBD) {
            return 2;
        } else {
            return 3;
        }
    }
}
