using UnityEngine;

public interface IHealth
{
    /// <summary>
    /// 造成伤害
    /// </summary>
    /// <param name="damage">伤害量</param>
    /// <param name="instigator">发起伤害者</param>
    void Damage(int damage,
                GameObject instigator);

    /// <summary>
    /// 初始化
    /// </summary>
    void Initialization();
}
