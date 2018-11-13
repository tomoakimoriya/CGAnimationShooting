using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        if (this.transform.position.y < -100)
            Destroy(this.gameObject);
    }
}
