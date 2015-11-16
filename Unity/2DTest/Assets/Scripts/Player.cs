using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	// 移動スピード
	public float speed = 5;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		// 右左
		float x = Input.GetAxisRaw("Horizontal");

		// 上下
		float y = Input.GetAxisRaw("Vertical");

		// 移動する向きを求める
		Vector2 direction = new Vector2(x, y).normalized;

		// 移動する向きとスピードを代入する
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}
