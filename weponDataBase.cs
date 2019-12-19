using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weponDataBase : MonoBehaviour
{

	public enum weponState
	{
		シールド付きパイルバンカー = 1,
		パイルバンカー,
		マグナム,
		火炎放射器,
		スナイパー,
		ライフル,
		ドリル,
		ミサイル,
		ロケットパンチ,
		ロケット砲,
		デーモンコア君,
		ショートソード,
		ロングソード,
		忍者刀,
		薙刀,
		キャノン,
		ロケットポッド,
		補助ブースター,
		支援ユニット,
		シールド
	}

                   //武器性能(ジャンル、装備箇所、攻撃力、装填数)
    string EnumUse(weponState ws)
	{
		if (ws == weponState.シールド付きパイルバンカー)
		{
			string[] state = { "近接", "手", "2750", "1" };
		} else if (ws == weponState.パイルバンカー)
		{
			string[] state = { "近接", "手", "3000", "1" };
		}
		else if (ws == weponState.マグナム)
		{
			string[] state = { "中距離", "手", "1350", "6" };
		}
		else if (ws == weponState.火炎放射器)
		{
			string[] state = { "中距離", "手", "1075", "40" };
		}
		else if (ws == weponState.スナイパー)
		{
			string[] state = { "遠距離", "手", "2350", "1" };
		}
		else if (ws == weponState.ライフル)
		{
			string[] state = { "中距離", "手", "1065", "30" };
		}
		else if (ws == weponState.ドリル)
		{
			string[] state = { "近距離", "手", "1700", "3" };
		}
		else if (ws == weponState.ミサイル)
		{
			string[] state = { "遠距離", "手", "1500", "4" };
		}
		else if (ws == weponState.ロケットパンチ)
		{
			string[] state = { "遠距離", "手", "2000", "1" };
		}
		else if (ws == weponState.ロケット砲)
		{
			string[] state = { "遠距離", "手", "2500", "1" };
		}
		else if (ws == weponState.デーモンコア君)
		{
			string[] state = { "手榴弾", "手", "1250", "1" };
		}
		else if (ws == weponState.ショートソード)
		{
			string[] state = { "近接", "手", "1750", "1" };
		}
		else if (ws == weponState.ロングソード)
		{
			string[] state = { "近接", "手", "2000", "1" };
		}
		else if (ws == weponState.忍者刀)
		{
			string[] state = { "近接", "手", "1250", "1" };
		}
		else if (ws == weponState.薙刀)
		{
			string[] state = { "近接", "手", "3000", "1" };
		}
		else if (ws == weponState.キャノン)
		{
			string[] state = { "中距離", "肩", "3000", "1" };
		}
		else if (ws == weponState.ロケットポッド)
		{
			string[] state = { "遠距離", "肩", "1250", "6" };
		}
		else if (ws == weponState.補助ブースター)
		{
			string[] state = { "サブ", "肩", "0", "180" };
		}
		else if (ws == weponState.支援ユニット)
		{
			string[] state = { "サブ", "肩", "0", "1" };
		}
		else if (ws == weponState.シールド)
		{
			string[] state = { "防御", "肩", "3000", "1" };
		}
		return null;
	}

	public static string[,] weapon = {{"シールド付きパイルバンカー", "近接", "手", "2750", "1" }, 
		　　　　　　　　　　　　　　　　{"パイルバンカー", "近接", "手", "3000", "1" } ,
									  {"マグナム", "中距離", "手", "1350", "6" },
									  {"火炎放射器", "中距離", "手", "1075", "40" },
					    			  {"スナイパー", "遠距離", "手", "2350", "1" },
									  {"ライフル", "中距離", "手", "1065", "30" },
									  {"ドリル", "近距離", "手", "1700", "3" },
									  {"ミサイル", "遠距離", "手", "1500", "4" },
									　{"ロケットパンチ", "遠距離", "手", "2000", "1" },
									  {"ロケット砲", "遠距離", "手", "2500", "1" },
									　{"デーモンコア君", "手榴弾", "手", "1250", "1" },
									  {"ショートソード", "近接", "手", "1750", "1" },
									　{"ロングソード", "近接", "手", "2000", "1" },
									  {"忍者刀", "近接", "手", "1250", "1" },
									　{"薙刀", "近接", "手", "3000", "1" },
									  {"キャノン", "遠距離", "肩", "1250", "6" },
									　{"補助ブースター", "サブ", "肩", "0", "180" },
									  {"支援ユニット", "サブ", "肩", "0", "1" },
									　{"シールド", "防御", "肩", "3000", "1" }};
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
