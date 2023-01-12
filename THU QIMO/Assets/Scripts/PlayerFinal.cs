using UnityEngine;

namespace LUCIEN
{
    /// <summary>
    /// 玩家結束管理：死亡或過關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // 被刪除時會執行一次
        private void OnDestroy()
        {
            // 死亡
            FinalManager.instance.GameOver("挑戰失敗！");
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Monster"))
            {
                 FinalManager.instance.GameOver("挑戰失敗！");
            }
        }
    }
}
