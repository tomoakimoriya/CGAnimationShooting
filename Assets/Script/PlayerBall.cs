using UnityEngine;
using System.Collections;

public class PlayerBall : MonoBehaviour {
    public float speed = 30.0f;
    public float lifetime = 5.0f;
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        this.lifetime -= Time.deltaTime;
        if (lifetime <= 0)
            Destroy(this.gameObject);

        this.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == "Enemy" || layerName == "EnemyBullet")
        {
            Destroy(this.gameObject);
        }
    }
}
