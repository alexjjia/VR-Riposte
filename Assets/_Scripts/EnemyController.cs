using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public float speed;
    public GameObject target;
    private float attackRange; //the range in which the enemy can begin attacking the target.
    // Use this for initialization
	void Start () {
        transform.LookAt(target.transform);
        attackRange = 2f;
    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Pow((Mathf.Pow((this.transform.position.x - target.transform.position.x), 2) + Mathf.Pow((this.transform.position.z - target.transform.position.z), 2)), 0.5f) > attackRange)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    public void getDestroyed()
    {
        this.gameObject.SetActive(false); // disables it for now; replace this with the Destroy() func once we get spawning and other kinks down.
    }

}
