using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    Vector3 maju;
    Vector3 mundur;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 kiri;
    Vector3 kanan;

    public int speed;
    public int speedRotasi;
    int score;
    
    void Start()
    {
        maju = new Vector3(1, 0, 0);
        mundur = new Vector3(-1, 0, 0);
        keatas = new Vector3(0, 1, 0);
        kebawah = new Vector3(0, -1, 0);
        kiri = new Vector3(0, 0, 1);
        kanan = new Vector3(0,0,-1);
    }
    
    void Update()
    {
        if (Input.GetKey("d")) {
                transform.position = transform.position + (maju * speed * Time.deltaTime);
        }
            
        if (Input.GetKey("a")) {
                transform.position = transform.position + (mundur * speed * Time.deltaTime);
            }

        if (Input.GetKey("w")) {
                transform.position = transform.position + (keatas * speed * Time.deltaTime);
            }

        if (Input.GetKey("s")) {
                transform.position = transform.position + (kebawah * speed * Time.deltaTime);
            }
            
        if (Input.GetKey("e")) {
                transform.rotation = transform.rotation * Quaternion.Euler (kanan * speedRotasi * Time.deltaTime);
            }
            
        if (Input.GetKey("q")) {
                transform.rotation = transform.rotation * Quaternion.Euler (kiri * speedRotasi * Time.deltaTime);
            }
    }

    void OnCollisionEnter2D(Collision2D coll) {

        if (coll.gameObject.tag == "enemyTag") {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
 
        if (coll.gameObject.tag == "coinTag") {
            score += 1;
            Debug.Log("Coin = " + score);
        }
    }

    void OnCollisionStay2D(Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag") {
            Debug.Log("Sedang Nabrak");
        }
    }

    void OnCollisionExit2D(Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag") {
            Debug.Log("Sudah Nabrak");
        }
    }

}
