using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Block : MonoBehaviour {
    public float firewaitmax = 20.0f;
    public GameObject ball;
    float waittime;
    GameObject player;
    // Use this for initialization
    void Start () {
        waittime = Random.value * firewaitmax;
        player = GameObject.FindWithTag("Player");
    }
    
    // Update is called once per frame
    void Update () {
        waittime -= Time.deltaTime;
        if ((waittime < 0) && (player != null))
        {
            var newball = (GameObject)Instantiate(ball, this.transform.position, Quaternion.identity);
            newball.transform.LookAt(player.transform);
            waittime = Random.value * firewaitmax;
        }


    }

    void OnCollisionEnter(Collision other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == "PlayerBullet")
        {
            GameObject textui = GameObject.Find("Message");
            var text = textui.GetComponent<Text>().text;
            if (text != "GAMEOVER")
            {
                int score = int.Parse(text);
                score += 100;
                textui.GetComponent<Text>().text = score.ToString();
            }
            Destroy(this.gameObject);
        }
    }
}
