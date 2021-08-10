using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboard : MonoBehaviour
{
    public int X = 0;
    public GameObject White;
    public GameObject Black;
    public Transform parent;
    public Text KeyCharacter;
    public List<GameObject> Keys = new List<GameObject>();
    float P;
    

    public void OnVolumeChange(float value)
    {
        for (int l = 0; l < Keys.Count; l++)
        {
            Keys[l].GetComponent<AudioSource>().volume=value;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                
                Keys.Add(Instantiate(White));
                Keys[X].GetComponent<Transform>().SetParent(parent);
                Keys[X].GetComponent<Transform>().localScale=new Vector3(1,1,1);
                Keys[X].GetComponent<RectTransform>().localPosition=new Vector3(50*j+350*i-400,-35,0);
                X++;
                if (j%3 != 0)
                {
                Keys.Insert(X-1,Instantiate(Black));
                Keys[X-1].GetComponent<Transform>().SetParent(parent);
                Keys[X-1].GetComponent<Transform>().localScale=new Vector3(1,1,1);
                Keys[X-1].GetComponent<RectTransform>().localPosition=new Vector3(50*j+350*i-425,20,0);
                X++;
                }
            }
            Keys.Add(Instantiate(White));
            Keys[X].GetComponent<Transform>().SetParent(parent);
            Keys[X].GetComponent<Transform>().localScale=new Vector3(1,1,1);
            Keys[X].GetComponent<RectTransform>().localPosition=new Vector3(350*i-100,-35,0);
            X++;
            Keys.Insert(X-1,Instantiate(Black));
            Keys[X-1].GetComponent<Transform>().SetParent(parent);
            Keys[X-1].GetComponent<Transform>().localScale=new Vector3(1,1,1);
            Keys[X-1].GetComponent<RectTransform>().localPosition=new Vector3(350*i-125,20,0);
            X++;
        }
        for (int k = 0; k < Keys.Count; k++){
            P = Mathf.Pow(2,(k-11f)/12f);
            Keys[k].GetComponent<AudioSource>().pitch= P;
            KeyCharacter = Keys[k].GetComponent<Transform>().GetComponentInChildren<Text>();
            switch (k)
            {case 0:
                KeyCharacter.text="Z";
                break;
            case 1:
                KeyCharacter.text="S";
                break;
            case 2:
                KeyCharacter.text="X";
                break;
            case 3:
                KeyCharacter.text="D";
                break;
            case 4:
                KeyCharacter.text="C";
                break;
            case 5:
                KeyCharacter.text="V";
                break;
            case 6:
                KeyCharacter.text="G";
                break;
            case 7:
                KeyCharacter.text="B";
                break;
            case 8:
                KeyCharacter.text="H";
                break;
            case 9:
                KeyCharacter.text="N";
                break;
            case 10:
                KeyCharacter.text="J";
                break;
            case 11:
                KeyCharacter.text="M";
                break;
            case 12:
                KeyCharacter.text=",\nQ";
                break;
            case 13:
                KeyCharacter.text="L\n2";
                break;
            case 14:
                KeyCharacter.text=".\nW";
                break;
            case 15:
                KeyCharacter.text=";\n3";
                break;
            case 16:
                KeyCharacter.text="/\nE";
                break;
            case 17:
                KeyCharacter.text="R";
                break;
            case 18:
                KeyCharacter.text="5";
                break;
            case 19:
                KeyCharacter.text="T";
                break;
            case 20:
                KeyCharacter.text="6";
                break;
            case 21:
                KeyCharacter.text="Y";
                break;
            case 22:
                KeyCharacter.text="7";
                break;
            case 23:
                KeyCharacter.text="U";
                break;
            case 24:
                KeyCharacter.text="I";
                break;
            case 25:
                KeyCharacter.text="9";
                break;
            case 26:
                KeyCharacter.text="O";
                break;
            case 27:
                KeyCharacter.text="0";
                break;
            case 28:
                KeyCharacter.text="P";
                break;
            case 29:
                KeyCharacter.text="@";
                break;
            case 30:
                KeyCharacter.text="^";
                break;
            case 31:
                KeyCharacter.text="[";
                break;
            default:
                KeyCharacter.text="";
                break;

                        
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Keys[0].GetComponent<AudioSource>().Play();
        }

         
         if (Input.GetKeyDown(KeyCode.S))
        {
            Keys[1].GetComponent<AudioSource>().Play();
        }
         
         
         if (Input.GetKeyDown(KeyCode.X))
        {
            Keys[2].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.D))
        {
            Keys[3].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.C))
        {
            Keys[4].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.V))
        {
            Keys[5].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.G))
        {
            Keys[6].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.B))
        {
            Keys[7].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.H))
        {
            Keys[8].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.N))
        {
            Keys[9].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.J))
        {
            Keys[10].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.M))
        {
            Keys[11].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Comma)|Input.GetKeyDown(KeyCode.Q))
        {
            Keys[12].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.L)|Input.GetKeyDown(KeyCode.Alpha2))
        {
            Keys[13].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Period)|Input.GetKeyDown(KeyCode.W))
        {
            Keys[14].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Equals)|Input.GetKeyDown(KeyCode.Alpha3))
        {
            Keys[15].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Slash)|Input.GetKeyDown(KeyCode.E))
        {
            Keys[16].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.R))
        {
            Keys[17].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Keys[18].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.T))
        {
            Keys[19].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Keys[20].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Y))
        {
            Keys[21].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Keys[22].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.U))
        {
            Keys[23].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.I))
        {
            Keys[24].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Keys[25].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.O))
        {
            Keys[26].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Keys[27].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.P))
        {
            Keys[28].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            Keys[29].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.Caret))
        {
            Keys[30].GetComponent<AudioSource>().Play();
        }
         
         if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            Keys[31].GetComponent<AudioSource>().Play();
        }
             
         if (Input.GetKeyUp(KeyCode.Z))
        {
            Keys[0].GetComponent<AudioSource>().Stop();
        }

         
         if (Input.GetKeyUp(KeyCode.S))
        {
            Keys[1].GetComponent<AudioSource>().Stop();
        }
         
         
         if (Input.GetKeyUp(KeyCode.X))
        {
            Keys[2].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.D))
        {
            Keys[3].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.C))
        {
            Keys[4].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.V))
        {
            Keys[5].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.G))
        {
            Keys[6].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.B))
        {
            Keys[7].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.H))
        {
            Keys[8].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.N))
        {
            Keys[9].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.J))
        {
            Keys[10].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.M))
        {
            Keys[11].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Comma)|Input.GetKeyUp(KeyCode.Q))
        {
            Keys[12].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.L)|Input.GetKeyUp(KeyCode.Alpha2))
        {
            Keys[13].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Period)|Input.GetKeyUp(KeyCode.W))
        {
            Keys[14].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Equals)|Input.GetKeyUp(KeyCode.Alpha3))
        {
            Keys[15].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Slash)|Input.GetKeyUp(KeyCode.E))
        {
            Keys[16].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.R))
        {
            Keys[17].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            Keys[18].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.T))
        {
            Keys[19].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            Keys[20].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Y))
        {
            Keys[21].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            Keys[22].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.U))
        {
            Keys[23].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.I))
        {
            Keys[24].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            Keys[25].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.O))
        {
            Keys[26].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            Keys[27].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.P))
        {
            Keys[28].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.BackQuote))
        {
            Keys[29].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.Caret))
        {
            Keys[30].GetComponent<AudioSource>().Stop();
        }
         
         if (Input.GetKeyUp(KeyCode.LeftBracket))
        {
            Keys[31].GetComponent<AudioSource>().Stop();
        }
    }
                
    
}
