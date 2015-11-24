﻿using UnityEngine;
using System.Collections;

// Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public abstract class Spaceship : MonoBehaviour
{
	// 移動スピード
	public float speed;

	// 弾を撃つ間隔
	public float shotDelay;

	// 弾のPrefab
	public GameObject bullet;

	// 弾を撃つかどうか
	public bool canShot;

	// 爆発のPrefab
	public GameObject explosion;

	// アニメーターコンポーネント
	private Animator animator;

	// 爆発の作成
	public void Explosion()
	{
		Instantiate(explosion, transform.position, transform.rotation);
	}

	// 弾の作成
	public void Shot(Transform origin)
	{
		Instantiate(bullet, origin.position, origin.rotation);
	}

	// アニメーターコンポーネントの取得
	public Animator GetAnimator()
	{
		if(animator == null)
		{
			animator = GetComponent<Animator>();
		}

		return animator;
	}

	protected abstract void Move(Vector2 direction);
}
