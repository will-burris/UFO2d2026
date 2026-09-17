//What kind of coding engine is VS code using.
using UnityEngine;

//
public class Pickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D _other){
        if(_other.gameObject.tag != "Player"){
            return;
        }
        _other.GetComponent<Movement_Keys>().speed *= 2.0f;

        Destroy(gameObject);
    }
}