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
        //base(�θ���)
        base.Move(); //�θ�Ϳ� �ƹ��� ������ �� ��� ��
        //�̾�ϴ� ���� �� ������ ��
        print("������ �߻��մϴ�.");

    }
}
