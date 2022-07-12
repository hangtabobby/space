using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
using Random = UnityEngine.Random;

[System.Serializable]

public class WaveInfo
{
    public int numEnemy;
}
public class Wavecontroller : MonoBehaviour
{
    
    int currentEnemy;
    private int currentWave=0;
    [SerializeField] WaveInfo[]waves;
    private void Awake()
    {
        Observer.Instance.AddObserver(Observerkey.ENEMY_DIE,OnEnemyDie);
    }

    public void Start()
    {
        CreateEnemies(waves[currentWave]);
    }

    public void NextWave()
    {
        Debug.Log("wave");
        currentWave++;
        if (currentWave >= waves.Length)
        {
            Debug.Log("YouWin");
            return;
        }
        CreateEnemies(waves[currentWave]);
    }
    public void OnEnemyDie(object data)
    {
        
        currentEnemy--;
        if (currentEnemy==0)
        {
            Debug.Log("nextwave"+currentWave);
            NextWave();
        }

    }

    public void CreateEnemies(WaveInfo waveInfo)
    {
        
        currentEnemy = waveInfo.numEnemy;
        for (int i = 0; i < waveInfo.numEnemy; i++)
        {
            Debug.Log(i);
            Creater.Instance.CreateEnemy(new Vector3(Random.Range(-5f,5f),Random.Range(5f,8f)));

        }
    }
    private void OnDestroy()
    {
        Observer.Instance.RemoveObserver(Observerkey.ENEMY_DIE,OnEnemyDie);
        
    }
}
