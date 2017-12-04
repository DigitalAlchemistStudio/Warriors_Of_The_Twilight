using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {


	public GameObject Square;

	// Size of the map in terms of number of tiles
	// This is NOT representative of the amount of
	// world space that we're going to take up
	// (i.e. our tiles might be more or less than 1 Unity World Unit)

	int width = 20;
	int height = 20;


	// Use this for initialization
	void Start () 
    {

        for (int x = 0; x < width; x++)
            for (int y = 0; y <height; y++)
            {

            }
        {

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
