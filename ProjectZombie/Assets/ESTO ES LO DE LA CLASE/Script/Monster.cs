using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public enum MonsterState
    {
        standing,
        wandering,
        chasing,
        attacking
    }

    public MonsterState mState;

    void Start()
    {
        mState = MonsterState.attacking;
        int number = (int)mState;
        Debug.Log(number);

    }
   
  


	void Update ()
	{
		
	}
}
