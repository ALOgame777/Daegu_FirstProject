using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    // 속성(변수의 일종)
    // public int healthPoint {get; set;}
    public int healthPoint
    { 
        //읽기
        get;

        //설정하기, 넣는 것
        set;
        
    }
    //protected 상속받은 것만 열어둠
    protected int hp = 100;
    public float attackPower = 5.5f;
    public string myName ="검객";

    //생성자 함수(Constructor)
    //public SwordMan(int health, float atk, string nickName)
    //{
    //    hp = health;
    //    attackPower = atk;
    //    myName = nickName;
    //}    

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //선언부(헤더)
    //구현부(바디)
   public virtual void Move()
    {
        print(myName + "(이)가 이동합니다!");
    }

    public float Attack(string targetName)
    {
        print(targetName + "에게 " + attackPower.ToString() + "만큼 피해를 줍니다.");
        return attackPower;
    }

    public void Die()
    {
        print("사망했습니다.");
    }


    //get set 함수로 만들기
    public int GetHP()
    {
        return hp;
    }

    public void SetHP(int health)
    {
        hp = health;
    }
}
