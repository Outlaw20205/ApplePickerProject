using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [SerializeField] private GameObject   applePrefab;
    [SerializeField] private GameObject   branchPrefab;
    public float        speed = 1f;
    public float        leftAndRightEdge = 10f;
    public float        changeDirChance = 0.1f;
    public float        appleDropDelay = 1f;

    void Start() {
        // start dropping apples
        Invoke("DropObject", 2f);
    }

    GameObject RandomObjectGen() {
        int random = Random.Range(0, 15);
        return random % 5 == 0 ? branchPrefab : applePrefab;
    }

    void DropObject() {
        GameObject randObj = Instantiate<GameObject>(RandomObjectGen());

        if (randObj == applePrefab) {
            randObj.transform.position = transform.position;
        }
        else {

            randObj.transform.position = transform.position;
        }
    
        Invoke("DropObject", appleDropDelay);
    }

    // Update is called once per frame
    void Update(){
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing dir
        if(pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed);
        }
        /*else if (Random.value < changeDirChance) {
            speed *= 1;
        }*/
    }

    void FixedUpdate() {
        // Random dir change are now time-based
        if (Random.value < changeDirChance) {
            speed *= -1;
        }
    }
}
