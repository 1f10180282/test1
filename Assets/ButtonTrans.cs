using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrans : MonoBehaviour
{
    [SerializeField] Image[] Button;
    public GameObject a;
    [SerializeField] GameObject Panel;
  
   


    // Start is called before the first frame update
    public void ColorChange(int number)
    {
        //ボタン色変更
        for (int i = 0; i < Button.Length; i++)
        {
            Button[i].color = new Color32(255, 255, 255 ,255);
        }
        Button[number].color = new Color32(200, 200, 200, 255);


        //ボタンpanel推移
        switch (number)
        {
            case 0:
                Panel.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;
            case 1:
                Panel.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;
            case 2:
                Panel.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;
            case 3:
                Panel.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;
          
        }


        
    }
}
