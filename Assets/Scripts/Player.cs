using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Pokemon[] pokemon;
    public int curPokemon = 0;

    public Pokemon GetPokemon() {
        return pokemon[curPokemon];
    }
    
}
