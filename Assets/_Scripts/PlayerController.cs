using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Slider healthBar;
    public GameObject target;
    public float hurtRange;
	// Use this for initialization
	void Start () {
        hurtRange = 0.5f;
	}
	
    float getDistance(GameObject first, GameObject second)
    {
        return Mathf.Pow((Mathf.Pow((first.transform.position.x - second.transform.position.x), 2) + Mathf.Pow((first.transform.position.z - second.transform.position.z), 2)), 0.5f);
    }
	// Update is called once per frame
	void FixedUpdate () {
        if(target.tag == "Enemy")
        {
            if(getDistance(this.gameObject, target) < hurtRange)
            {
                getHurt(true);
            }
        }
    }

    void getHurt(bool flag)
    {
        if(flag == true)
        {
            healthBar.value -= 0.11f;
        }
    }
}
