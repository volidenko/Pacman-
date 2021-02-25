using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    GameMaster master;
    public GameObject btnLose;
    // Start is called before the first frame update
    void Start()
    {
        master=GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name=="Enemy"){
            btnLose.SetActive(true);
            print("Lose");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag=="Crystall"){
            Destroy(other.gameObject);
            master.playerScore++;
            print(master.playerScore);
        }
    }
}