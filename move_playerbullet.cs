using UnityEngine;
using System.Collections;

public class move_playerbullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//弾を動かす
		transform.Translate (0, 0, 1.0f);
		//お馴染みのやつ。今回は必要なくなるかも？？
		if (transform.position.z > 100) {
			//ﾃﾞｽﾄﾛｫｫｫｫｫｫｫｫｫｫｫｲｲｲｲｲ
			Destroy (gameObject);
		}
	}
}
