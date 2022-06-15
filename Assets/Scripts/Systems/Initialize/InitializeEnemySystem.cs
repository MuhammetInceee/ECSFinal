using UnityEngine;
using Entitas;

public class InitializeEnemySystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public InitializeEnemySystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize() 
    {
        for (int i = GameConfig.Instance.enemySpawnMinY; i < GameConfig.Instance.enemySpawnMaxY; i++)
        {
            CreateEnemy(i);
        }
    }

    public void CreateEnemy(int i)
    {
        var e = _contexts.game.CreateEntity();
        e.AddPosition(0, (i * Random.Range(2f, 2.15f)), 0);
        e.isEnemy = true;
        e.AddResource(GameConfig.Instance.enemyPrefab);
    }
}