/**
 * @author BoLuo
 * @email [ tktetb@163.com ]
 * @create date 17:09:16
 * @modify date 17:09:16
 * @desc []
 */

using System;
using UnityEngine;

namespace DefaultNamespace
{
    /// <summary>
    /// 血量
    /// todo 对值做一些访问限制
    /// </summary>
    public class Health : MonoBehaviour,IHealth
    {
        #region fields

        [Tooltip("当前血量")]
        public int CurrentHealth;

        [Tooltip("初始血量")]
        public int InitialHealth = 10;

        [Tooltip("最大血量")]
        public int MaximumHealth = 10;

        /// <summary>
        /// 上次受到的伤害值
        /// </summary>
        public int LastDamage { get; set; }

        #endregion

        #region public

        #endregion

        private void Awake()
        {
            Initialization();
        }

        public void Damage(int damage,
                           GameObject instigator)
        {
            // 血量已经低于0
            if ((CurrentHealth <= 0) && (InitialHealth != 0))
            {
                return;
            }

            // 减去伤害
            CurrentHealth -= damage;

            // 如果血量小于0
            if (CurrentHealth <= 0)
            {
                // 设置为0
                CurrentHealth = 0;
            }

            LastDamage = damage;
        }

        public void Initialization()
        {
            CurrentHealth = InitialHealth;
        }
    }
}