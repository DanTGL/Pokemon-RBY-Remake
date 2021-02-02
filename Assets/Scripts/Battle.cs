using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    int GetRandomMove() {
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
