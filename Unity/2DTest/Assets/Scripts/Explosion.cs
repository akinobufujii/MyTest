using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
	// アニメーション終了後
	void OnAnimationFinish()
	{
		Destroy(gameObject);
	}
}
