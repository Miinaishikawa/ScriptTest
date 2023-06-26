using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;
    public void Magic(int damage)
    {
        if (mp >= damage)
        {
            this.mp -= damage;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("mpが足りないため、魔法が使えない。");
        }
        
    }


}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }
        

        int[] points1 = new int[5];

        points1[0] = 0;
        points1[1] = 1;
        points1[2] = 2;
        points1[3] = 3;
        points1[4] = 4;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points1[i]);
        }
        int[] points2 = new int[5];

        points2[0] = 4;
        points2[1] = 3;
        points2[2] = 2;
        points2[3] = 1;
        points2[4] = 0;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points2[i]);
        }
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
