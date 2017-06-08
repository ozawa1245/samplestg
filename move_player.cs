using UnityEngine;
using System.Collections;

public class move_player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	//弾。宣言しないで泣きを見た。
	public GameObject PlayerBullet;
	
	// Update is called once per frame
	void Update () {
		Vector3 v = this.transform.position;	//一旦変数として取り出す
												//C#では構造体を直接書き換えられないらしい
		if (Input.GetKey(KeyCode.LeftArrow)){
			v.x -= 0.05f;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			v.x += 0.05f;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			v.y += 0.05f;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			v.y -= 0.05f;
		}
		this.transform.position = v;			//そして戻す
		//弾を生む処理
		if (Input.GetKey (KeyCode.Z)) {
				Instantiate (PlayerBullet, transform.position, Quaternion.identity);
		}
	}
}
