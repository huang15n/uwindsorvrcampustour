using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    string url = "https://www.google.com/maps/search/?api=1&query=47.5951518,-122.3316393";
    public double latitude = 42.30508581367254;
    public double longitude = -83.06436567994649;
    LocationInfo li;
    public int zoom = 14;
    public int mapWidth = 600;
    public int mapHeight = 600;

    public enum mapType { roadmap, satellite, hybrid, terrain};
    // Use this for initialization
    public mapType mapSelected;
    public int scale;
    private bool loadingMap = false;

    private IEnumerator mapCoroutine;

  
}
