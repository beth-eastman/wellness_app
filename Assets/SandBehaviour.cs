using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandBehaviour : MonoBehaviour {


    public Terrain terrain;

    private TerrainData terrainData;

    // Initialization

    void Awake()
    {
        terrainData = Terrain.activeTerrain.terrainData;
    }

    void Start () {
        EditTerrain();
	}
	
	// Called once per frame
	void Update () {
		// Detect collision of rake

        // Based on rake position, modify heightmap

        // Create 5 lines around rake spokes

        // Update heightmap with new data
	}

    private void EditTerrain()
    {
        int heightmapWidth = terrainData.heightmapWidth;
        int heightmapHeight = terrainData.heightmapHeight;
        float[,] heights = terrainData.GetHeights(0, 0, heightmapWidth, heightmapHeight);

        Debug.Log(heightmapHeight);
        Debug.Log(heightmapWidth);
    }
    
}
