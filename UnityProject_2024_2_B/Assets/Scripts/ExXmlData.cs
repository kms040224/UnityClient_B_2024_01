using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

public class PlayerData
{
    public string playerName;
    public int playerLevel;
    public List<string> items = new List<string>();
}

public class ExXmlData : MonoBehaviour
{
    string filePath;
    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/PlayerData.xml";
        Debug.Log(filePath);
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerData playerData = new PlayerData();
            playerData.playerName = "플레이어 1";
            playerData.playerLevel = 1;
            playerData.items.Add("돌 1");
            playerData.items.Add("바위 1");
            SaveData(playerData);
                
        }

            if(Input.GetKeyDown(KeyCode.L))
        {
            PlayerData playerData = new PlayerData();

            playerData = LoadData();

            Debug.Log(playerData.playerName);
            Debug.Log(playerData.playerLevel);
            Debug.Log(playerData.items[0]);
            Debug.Log(playerData.items[1]);
        }
    }

    void SaveData(PlayerData data)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(PlayerData));                      //파일스트림 함수로 파일 생성
        FileStream stream = new FileStream(filePath, FileMode.Create);                          //클래스 -> XML 변환 후 저장

        serializer.Serialize(stream, data);
        stream.Close();
    }

    PlayerData LoadData()
    {
        if (File.Exists(filePath))

        {
            XmlSerializer serializer = new XmlSerializer(typeof(PlayerData));
            FileStream stream = new FileStream(filePath, FileMode.Open); //파일 읽기모드로 파일 열기
            PlayerData data = (PlayerData)serializer.Deserialize(stream);//XML -> 클래스 읽어서 변환
            stream.Close();
            return data;
        }
        else
        {
            return null;
        }
    }
}
