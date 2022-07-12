using System;
using System.Collections;
using System.Collections.Generic;
using LTAUnityBase.Base.DesignPattern;
using UnityEngine;
using Random = UnityEngine.Random;

public class Observerkey
{
    public const string ENEMY_DIE = " EnemyDie";
    public const string WAVE_DONE = " WaveDone";
}

public class GameController : MonoBehaviour
{
    //public int numEnemy;
    //public int currentEnemy=0;
    //public bool isPlaying = false;
    //public bool isAllowStartGame = true;
    
}
public class Game: SingletonMonoBehaviour<GameController>{}
