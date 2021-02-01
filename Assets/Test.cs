using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;
    private int hp = 100;
    private int power = 25;

    public void Magic(int usemp)
    {
        if(mp >= usemp) // 残りMPが消費MP以上の場合
        {
            mp -= usemp;                                // MP消費
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。"); // コンソールに表示
        }
        else           // MPが足りない場合
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}





public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // 課題ここから
        int[] array = { 5, 10, 20, 35, 55 }; 

        // arrayの各要素を順番に表示
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // arrayの各要素を逆順に表示
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // 発展課題ここから
        Boss lastboss = new Boss();

        // 関数Magicを11回コール
        for(int i = 0; i < 11; i++)
        {
            lastboss.Magic(5); // 消費MP5で魔法を使う
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
