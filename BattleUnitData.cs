using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnitData : MonoBehaviour
{
    //ユニット名
    public static string[] unitName = {"PS-P01","PS-W01","PS-G01"}; //2 1 3 武器の数

    //ユニットHP,防御力
    public static int[,] unitData = {{5000,1000,},  //PS-P01(中量)
                                     {3500,750,},   //PS-W01(軽量)
                                     {7500,1250}}; //PS-G01(重量)


    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
