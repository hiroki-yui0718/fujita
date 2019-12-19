using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboData : MonoBehaviour
{




    //private GameObject GameObject;

    //PS-G01(重量型)ステータス
    int hp_G;
    int light_G;
    int middle_G;
    int heavy_G; 
    int speed_G;
    string unitName_G;

    //PS-P01(中量型)ステータス
    int hp_P;
    int light_P;
    int middle_P;
    int heavy_P;
    int speed_P;
    string unitName_P;

    //PS-W01(軽量型)ステータス
    int hp_W;
    int light_W;
    int middle_W;
    int heavy_W;
    int speed_W;
    string unitName_W;

    // Start is called before the first frame update
    void Start()
    {
        //if (GameObject.Find("PS-G01")) {
            unitName_G = unitDataBase.unit[2, 0];
            hp_G = int.Parse(unitDataBase.unit[2, 1]);
            light_G = int.Parse(unitDataBase.unit[2, 2]);
            middle_G = int.Parse(unitDataBase.unit[2, 3]);
            heavy_G  = int.Parse(unitDataBase.unit[2, 4]);
            speed_G  = int.Parse(unitDataBase.unit[2, 5]);

        //}
        //else if (GameObject.Find("PS-P01"))
        //{
            unitName_P = unitDataBase.unit[0, 0];
            hp_P = int.Parse(unitDataBase.unit[0, 1]);
            light_P = int.Parse(unitDataBase.unit[0, 2]);
            middle_P = int.Parse(unitDataBase.unit[0, 3]);
            heavy_P = int.Parse(unitDataBase.unit[0, 4]);
            speed_P = int.Parse(unitDataBase.unit[0, 5]);

        //}
        //else if (GameObject.Find("PS-W01"))
        //{
            unitName_W = unitDataBase.unit[1, 0];
            hp_W = int.Parse(unitDataBase.unit[1, 1]);
            light_W = int.Parse(unitDataBase.unit[1, 2]);
            middle_W = int.Parse(unitDataBase.unit[1, 3]);
            heavy_W = int.Parse(unitDataBase.unit[1, 4]);
            speed_W = int.Parse(unitDataBase.unit[1, 5]);
        //}

        print("UNIT:" + unitName_G);
        print("HP:" + hp_G);
        print("LIGHT:" + light_G);
        print("MIDDLE:" + middle_G);
        print("HEAVY:" + heavy_G);
        print("SPEED:" + speed_G);

        print("UNIT:" + unitName_P);
        print("HP:" + hp_P);
        print("LIGHT:" + light_P);
        print("MIDDLE:" + middle_P);
        print("HEAVY:" + heavy_P);
        print("SPEED:" + speed_P);

        print("UNIT:" + unitName_W);
        print("HP:" + hp_W);
        print("LIGHT:" + light_W);
        print("MIDDLE:" + middle_W);
        print("HEAVY:" + heavy_W);
        print("SPEED:" + speed_W);
    }
    
    // Update is called once per frame
    void Update()
    {
    }
}
