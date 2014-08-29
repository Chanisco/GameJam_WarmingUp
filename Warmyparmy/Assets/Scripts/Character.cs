// // // // // // // // 
// 19 / 08 / 14   // //
// By Floris de Haan //
// // // // // // // //

using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    // health
    public static float Lives = 6;
    
    private Animator animator;
    private static float _fallAnimIndex = 0;
    private static bool _falling = false;

    private static float _targetX;
    public float _speed = 0.8f;

	void Start()
    {
		animator = GetComponent<Animator>();
        _targetX = transform.position.x;
	}
<<<<<<< HEAD:Warmyparmy/Assets/Character.cs
	
	void Update ()
    {
        // Falling
        if (_falling)
        {
            animator.SetFloat("Failing", _fallAnimIndex);
            _fallAnimIndex -= 1;
            if (_fallAnimIndex < 0) _falling = false;
        }

        // Move
        MoveToTarget();
        
        // End of game
        if(ArrowSpawn.i > 40)
        {
			animator.SetBool("Solo", true);
=======

	void Update () {
		if(Fall){
			PositionMaker(Lives);
>>>>>>> origin/master:Warmyparmy/Assets/Scripts/Character.cs
		}
	}

    private void MoveToTarget()
    {
        // Current pos
        float x = transform.position.x;
        
        // Movement
        float xMovement = Mathf.Min(new float[] { _targetX - x, _speed });

        // Cancel if too low, fix flickering
        if (Mathf.Abs(xMovement) < 0.1f) return;
        
        // Apply
        transform.Translate(new Vector3(xMovement * Time.deltaTime, 0, 0));
    }

    public static void Hit()
    {
        if (Lives < 1) return;

        _falling = true;
        _fallAnimIndex = 5;
        _targetX -= 1f;
        Lives--;
    }

    public static void Accelerate()
    {
        if (Lives > 6) return;
        print("Acc");
        _targetX += 2f;
        Lives++;
    }

	void OnTriggerEnter(Collider other)
    {
		if(other.tag == Tags.Enemy)
        {
			Destroy(gameObject);
		}
	}
}
