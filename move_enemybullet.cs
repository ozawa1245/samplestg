using UnityEngine;
using System.Collections;

public class move_enemybullet : MonoBehaviour {


	// Use this for initialization
	Rigidbody rb;
	void Start () {
		/*float x = (Random.Range(-5.0f, 5.0f));
		float y = (Random.Range(-5.0f, 5.0f));
		float z = (Random.Range(-5.0f, 5.0f));
		Vector3 vec = new Vector3 (x, y, z);
		GetComponent<Rigidbody> ().velocity = vec;*/
	}
	// 移動速度を設定
	// @param angle1 z軸との角度
	// @param angle2 x軸との射影がなす角度 
	// @param speed 速さ
	// @param rotate 回転量
	public void Create(float angle1, float angle2, float speed) {
		rb = GetComponent<Rigidbody> ();
		Vector3 v;
		v.x = Mathf.Sin(angle1 * (Mathf.PI / 180)) * Mathf.Cos(angle2 * (Mathf.PI / 180)) * speed;
		v.y = Mathf.Sin(angle1 * (Mathf.PI / 180)) * Mathf.Sin(angle2 * (Mathf.PI / 180)) * speed;
		v.z = Mathf.Cos(angle1 * (Mathf.PI / 180)) * speed;
		rb.velocity = v;
		Destroy (gameObject, 4);
	}

	/*public void Create(float angle, float speed) {
		//do
	}*/
		
	// Update is called once per frame
	void Update () {
		//弾を動かす
		//transform.Translate (EnemyBullet.velocity);
		/*//お馴染みのやつ。今回は必要なくなるかも？？
		if (transform.position.z > 100) {
			//ﾃﾞｽﾄﾛｫｫｫｫｫｫｫｫｫｫｫｲｲｲｲｲ
			Destroy (gameObject);
		}*/
	}

	void FixedUpdate() {
		Rigidbody rd;
		rd = GetComponent<Rigidbody> ();
		// VectorとQuaternionを用意して回転させる
		Vector3 v = rb.velocity;
		Quaternion rotate = Quaternion.Euler (0.0f, 0.0f, 1.0f);
		// かけ合わせるだけなんだけど
		// Quaternion * Vectorじゃなきゃエラー吐かれる
		v = rotate * v;
		rb.velocity = v;
	}
}
