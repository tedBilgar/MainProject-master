using UnityEngine;
using System.Collections;

public class gEnemy : MonoBehaviour
{

    [System.Serializable]
    public class EnemyStats
    {
        public int Health = 100;
    }

    public EnemyStats stats = new EnemyStats();
    public static void KillEnemy(gEnemy other)
    {
        Destroy(other.gameObject);
    }
    public void DamageEnemy(int damage)
    {
        Debug.Log("Enemy hits player");
        stats.Health -= damage;
        if (stats.Health <= 0)
        {
            KillEnemy(this);
        }
    }
}

