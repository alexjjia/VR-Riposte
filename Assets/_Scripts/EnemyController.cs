using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public float speed;
    public GameObject target;
    private float attackRange; //the range in which the enemy can begin attacking the target.
    // Use this for initialization
	void Start () {
        transform.LookAt(target.transform);
        attackRange = 2.5f;
    }

    // Update is called once per frame
    void Update () {
        transform.position += transform.forward* speed * Time.deltaTime;
    }

}
