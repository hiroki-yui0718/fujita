using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillDataBase : MonoBehaviour
{
	//スキル性能(種類1、種類2、倍率、ジャンル、クールタイム)
	public enum skillState
	{
		パワーアタック = 1,
		パワーシュート,
		リペア,
		ペネトレイト,
		ジャミング
	}

	string[] EnumUse(skillState ss)
	{
		if(ss == skillState.パワーアタック)
		{
			string[] state = { "攻撃", "近接", "300", "強撃", "20" };
			return state;
		}else if(ss == skillState.パワーシュート)
		{
			string[] state = { "攻撃", "遠隔", "250", "強撃", "25" };
			return state;
		}else if(ss == skillState.リペア)
		{
			string[] state = { "補助", "回復", "60", "回復", "30" };
			return state;
		}else if(ss == skillState.ペネトレイト)
		{
			string[] state = { "攻撃", "遠隔", "200", "貫通", "30" };
			return state;
		}else if(ss == skillState.ジャミング)
		{
			string[] state = { "妨害", "近接", "30", "速度低下", "25" };
			return state;
		}
		return null;
	}

    public static string[,] skill = { { "攻撃", "近接", "300", "強撃", "20"},
                                      { "攻撃", "遠隔", "250", "強撃", "25"},
                                      { "補助", "回復", "60", "回復", "30"},
                                      { "攻撃", "遠隔", "200", "貫通", "30"},
                                      { "妨害", "近接", "30", "速度低下", "25"}};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
