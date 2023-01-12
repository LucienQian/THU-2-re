using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace LUCIEN
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        // 碰撞開始事件 一次
        private void OnCollisionEnter(Collision collision)
        {
            // print ("碰撞：" + collision.gameObject);

            // 如果 碰到物件的名稱 包含 敵機 就爆炸
            if (collision.gameObject.CompareTag("Monster"))
            {
                Destroy(gameObject);
            }

        }

        // 碰撞離開事件 一次
        private void OnCollisionExit(Collision collision)
        {

        }

        // 碰撞持續事件
        private void OnCollisionStay(Collision collision)
        {

        }
    }
}
