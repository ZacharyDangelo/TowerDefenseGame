using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;

    // Awake is called when the script instance is loaded.
    private void Awake() {
        points = new Transform[transform.childCount]; //Set size of array to number of child objects (waypoints)
        for(int i = 0; i < transform.childCount; i++) {
            points[i] = transform.GetChild(i);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
