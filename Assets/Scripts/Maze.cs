using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : SwordMan
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {
        //base(부모의)
        base.Move(); //부모것에 아무도 없으면 안 적어도 됨
        //이어서하는 것은 더 넣으면 됨
        print("먼지가 발생합니다.");

    }
}
