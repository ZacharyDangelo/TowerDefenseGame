using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Map : MonoBehaviour
{
    public static Transform startPoint;
    public static Transform endPoint;

    private static Grid tileGrid;

    // Awake is called when the script instance is loaded.
    private void Awake() {
        startPoint = transform.Find("Start");
        endPoint = transform.Find("End");
        tileGrid = gameObject.GetComponentInChildren<Grid>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            GetTile(Input.mousePosition);
        }   
    }

    public static Vector3 GetTile(Vector3 mousePos) {
        Debug.Log("Mouse pos: (" + mousePos.x + "," + mousePos.y + ")");
        Vector3 tilePos = tileGrid.GetCellCenterWorld(tileGrid.WorldToCell(mousePos));
        Debug.Log("Tile pos: (" + tilePos.x + "," + tilePos.y + ")");
        return tilePos;
    }


}
