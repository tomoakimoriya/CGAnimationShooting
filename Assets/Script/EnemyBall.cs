using UnityEngine;
using System.Collections;

public class EnemyBall : MonoBehaviour {
    public float destroyradius = 1000.0f;
    public float speed = 20.0f;
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        if (this.transform.position.sqrMagnitude >= destroyradius)
            Destroy(this.gameObject);

        this.transform.localPosition += this.transform.forward * speed * Time.deltaTime; 
    }
}
