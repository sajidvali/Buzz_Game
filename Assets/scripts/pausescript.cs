using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pausescript : MonoBehaviour {

bool ispause=false;
    public Sprite OnSprite;
    public Sprite OffSprite;
    //public Text t;
    public void pausegame()
{
	if(ispause){
		Time.timeScale=1;
		ispause=false;
		//t.text = "pause";
	}else
		{
		Time.timeScale=0;
		ispause=true;
		//t.text ="resume";
		}
	}
	
}

		
	