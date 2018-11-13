using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
    public GameObject bullet;

    // Use this for initialization
    void Start () {

    }
    
    // Update is called once per frame
    void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        this.transform.position -= Vector3.left * x * 0.1f;

        if (Input.GetButtonDown("Fire1"))
        {
            var newbullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
        }
    }
         
    void OnCollisionEnter(Collision other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == "EnemyBullet" || layerName == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
