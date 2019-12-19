using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class unitDataBase : MonoBehaviour
{
	//ステータス(体力、近接防御力、射撃防御力、爆破防御力、速力)
	//中央値(5000,1000,1000,1000,1000,50)
	
	/*public enum unitState
	{
		PS_P01 = 1,
		PS_W01,
		PS_G01
	}

    public unitState unit_type;

    public int[] EnumUse(unitState us)
    
	{

		if(us == unitState.PS_P01)

		{
			int[] state = { 5000, 1250, 1000, 750, 50 };
			return state;
		}else if(us == unitState.PS_W01){
			int[] state = { 3500, 1000, 750, 1250, 75 };
			return state;
		}else if(us == unitState.PS_G01)
		{
			int[] state = { 7500, 750, 1250, 1000, 25 };
			return state;
		}
		return null;
	}*/

    public static string[,] unit = { {"PS_P01", "5000", "1250", "1000", "750", "50" },
                                     {"PS_W01", "3500", "1000", "750", "1250", "75"},
                                     {"PS_G01", "7500", "750",  "1250", "1000", "25"} };



    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
