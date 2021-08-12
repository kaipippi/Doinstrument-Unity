using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Sequencer : MonoBehaviour
{ 
    public Slider BPMSlider;
    public InputField BPMinput;
    float bpm = 128;
    public GameObject Switch;
    GameObject[,] Switches = new GameObject[4,64];
    public Transform SwitchParent;
    public AudioClip[] Audios = new AudioClip[4];
    public List<Vector2Int> SequencerData = new List<Vector2Int>();
    Vector2Int[] Default ={new Vector2Int(3, 0),new Vector2Int(1, 2),new Vector2Int(3, 4),new Vector2Int(2, 4),new Vector2Int(1, 6),new Vector2Int(3, 8),new Vector2Int(1, 10),new Vector2Int(2, 12),new Vector2Int(3, 12),new Vector2Int(1, 14),new Vector2Int(0, 4),new Vector2Int(0, 12),
     new Vector2Int(2, 15),new Vector2Int(0, 15),new Vector2Int(3, 16),new Vector2Int(1, 18),new Vector2Int(3, 20),new Vector2Int(2, 20),new Vector2Int(1, 22),new Vector2Int(3, 24),new Vector2Int(1, 26),new Vector2Int(3, 28),new Vector2Int(2, 28),
     new Vector2Int(1, 29),new Vector2Int(2, 30),new Vector2Int(2, 31),new Vector2Int(0, 28),new Vector2Int(0, 20),new Vector2Int(0, 30),new Vector2Int(0, 31),new Vector2Int(3, 32),new Vector2Int(1, 34),new Vector2Int(3, 36),new Vector2Int(2, 36),
     new Vector2Int(1, 38),new Vector2Int(3, 40),new Vector2Int(1, 42),new Vector2Int(0, 36),new Vector2Int(3, 44),new Vector2Int(2, 44),new Vector2Int(0, 44),new Vector2Int(1, 46),new Vector2Int(2, 47),new Vector2Int(0, 47),new Vector2Int(3, 48),
     new Vector2Int(3, 50),new Vector2Int(1, 50),new Vector2Int(3, 52),new Vector2Int(2, 52),new Vector2Int(3, 54),new Vector2Int(1, 54),new Vector2Int(0, 52),new Vector2Int(3, 56),new Vector2Int(1, 56),new Vector2Int(3, 57),new Vector2Int(3, 58),
     new Vector2Int(3, 59),new Vector2Int(1, 57),new Vector2Int(1, 58),new Vector2Int(1, 59),new Vector2Int(3, 61),new Vector2Int(3, 62),new Vector2Int(3, 63),new Vector2Int(3, 60),new Vector2Int(1, 61),new Vector2Int(1, 62),new Vector2Int(1, 63),
     new Vector2Int(1, 60),new Vector2Int(0, 56),new Vector2Int(0, 60),new Vector2Int(0, 62),new Vector2Int(1, 31)};
    Toggle toggle;
    //音量
    public void VolumeChange(float vol)
    {

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 64; j++)
            {
                Switches[i,j].GetComponent<AudioSource>().volume= vol;
            }
        }
    
    }

    //BPMのスライダーによる変更
    public void BPMSliderChange(float BPMf)
    {
        bpm=BPMf;
        BPMinput.text=bpm.ToString();
    }

    //BPMの入力からの変更
    public void BPMinputChange(string BPMs)
    {
        bpm=float.Parse(BPMs);
        BPMSlider.value=bpm;
    }

    //入力データ
    public void ToggleValueChanged(Vector2Int change)
    {
        if (Switches[change.x,change.y].GetComponent<Toggle>().isOn)
        {
            SequencerData.Add(change);
        }
        else
        {
            SequencerData.Remove(change);
        }

    }


    //再生
    public void Play()
    {
        for (int i = 0; i < SequencerData.Count; i++)
        {
            Switches[SequencerData[i].x,SequencerData[i].y].GetComponent<AudioSource>().PlayDelayed(SequencerData[i].y*15f/bpm);
        }
        Invoke("Play",960f/bpm);
    }

    //停止
    public void Stop()
    {
        CancelInvoke();
        for (int i = 0; i < SequencerData.Count; i++)
        {
            Switches[SequencerData[i].x,SequencerData[i].y].GetComponent<AudioSource>().Stop();
        }
    }

    void Start()
    {
        //盤面の錬成
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 64; j++)
            {
                Switches[i,j]=Instantiate(Switch);
                var label = new Vector2Int(i,j);
                toggle=Switches[i,j].GetComponent<Toggle>();
                toggle.onValueChanged.AddListener(delegate {ToggleValueChanged(label);});
                Switches[i,j].GetComponent<RectTransform>().SetParent(SwitchParent);
                Switches[i,j].GetComponent<RectTransform>().localScale=new Vector3(1,1,1);
                Switches[i,j].GetComponent<RectTransform>().localPosition=new Vector3(70*j-400,-70*i+180,0);
                Switches[i,j].GetComponent<AudioSource>().clip= Audios[i];
                if (j%4==0)
                {
                    Switches[i,j].GetComponentInChildren<Image>().color= new Color32(170,207,82,255);
                    Switches[i,j].GetComponent<Transform>().GetChild(0).GetChild(0).GetComponent<Image>().color= new Color32(0,145,64,255);
                 if (j%16==0)
                {
                    Switches[i,j].GetComponentInChildren<Image>().color= new Color32(255,132,204,255);
                    Switches[i,j].GetComponent<Transform>().GetChild(0).GetChild(0).GetComponent<Image>().color= new Color32(255,0,106,255);
                }
                }

            }
        }

        //初期値の読み込み
        SequencerData.AddRange(Default);
        for (int k = 0; k < SequencerData.Count; k++)
        {
            Switches[SequencerData[k].x,SequencerData[k].y].GetComponent<Toggle>().isOn=true;
        }
        
    }

}
