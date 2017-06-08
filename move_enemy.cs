using UnityEngine;
using System.Collections;

public class move_enemy : MonoBehaviour {
	int t;
	float SwirlAngle;

	public Rigidbody EnemyBullet;
	// Use this for initialization
	void Start () {
		t = 0;
		SwirlAngle = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		t++;
		//弾を生む処理
		// 同心円に出るやつ
		if (t % 90 == 0) {
			float angle1, angle2, speed;
			// z軸との角度は一般には0 <= angle1 <= PI
			angle1 = Random.Range (0.0f, 180.0f);
			// x軸との射影の角度は一般には0 <= angle2 <= 2PI
			// なおこのコードではその値を超える模様
			angle2 = Random.Range (0.0f, 360.0f);
			// speedは適当に
			speed = 10.0f;
			for (int i = 0; i < 120; i++) {
				for (int j = 0; j < 3; j++) {
					Rigidbody shot = Instantiate (EnemyBullet, transform.position, transform.rotation) as Rigidbody;
					move_enemybullet move = shot.GetComponent<move_enemybullet> ();
					move.Create (angle1 + (i * 360) / 120, angle2 + (j * 360) / 3, speed);
				}
			}
		}
		// 渦上に出てくれる
		// 実際キモい
		/*
		if (t % 2 == 0) {
			for (int i = 0; i < 6; i++) {
				for (int j = 0; j < 6; j++) {
					Rigidbody shot = Instantiate (EnemyBullet, transform.position, transform.rotation) as Rigidbody;
					move_enemybullet move = shot.GetComponent<move_enemybullet> ();
					move.Create (SwirlAngle + (i * 360) / 6, 0.0f + (j * 360) / 6, 10.0f);
					SwirlAngle += 0.05f;
				}
			}
		}
		*/
		transform.Rotate (new Vector3 (0.3f, 0.3f, 0.3f));
	}
		
}
