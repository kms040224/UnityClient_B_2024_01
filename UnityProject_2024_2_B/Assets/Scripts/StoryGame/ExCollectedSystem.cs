using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ExItem
{
    public bool IsCollected;            //ȹ�� ����
}

public class ExCollectedSystem : MonoBehaviour
{

    public List<ExItem> collectedItem = new List<ExItem>();     //�÷��� �� ����Ʈ
    // Start is called before the first frame update
    void Start()
    {
        collectedItem.Add(new ExItem());
        collectedItem.Add(new ExItem());
        collectedItem[0].IsCollected = true;
        collectedItem[1].IsCollected = false;
        CheckllItemsCollected();
    }

    void CheckllItemsCollected()
    {
        if(collectedItem.All(item=> item.IsCollected))
        {
            Debug.Log("All Items Collected");
        }
        else
        {
            Debug.Log("Not All Items Collected");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
