using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyTypes enemyType;
    private int baseSpeed;
    [SerializeField] private int walkSpeed;
    [SerializeField] private int runSpeed;

    void Start()
    {
        if (enemyType != EnemyTypes.speedyWalk)
        {
            baseSpeed = walkSpeed;
        }
        else
        {
            baseSpeed = runSpeed;
        }
    }
}