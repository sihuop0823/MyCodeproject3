using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSelect : MonoBehaviour
{
    public List<Card> deck = new List<Card>();  // 카드 덱
    public int total = 0;  // 카드들의 가중치 총 합

    void Start()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            total += deck[i].weight;
        }
        ResultSelect();
    }

    public List<Card> result = new List<Card>();

    public Transform parent;
    public GameObject cardprefab;

    public void ResultSelect()
    {
        for (int i = 0; i < 10; i++)
        {
            // 가중치 랜덤을 돌리는거
            result.Add(RandomCard()); 
            // 비어있는 카드 생성
            CardUI cardUI = Instantiate(cardprefab, parent).gameObject.GetComponent<CardUI>();
            // 정보 쑤셔넣기
            cardUI.CardUISet(result[i]);
        }
    }
    public Card RandomCard()
    {
        int weight = 0;
        int selectNum = 0;

        selectNum = Mathf.RoundToInt(total * Random.Range(0.0f, 1.0f));

        for (int i = 0; i < deck.Count; i++)
        {
            weight += deck[i].weight;
            if (selectNum <= weight)
            {
                Card temp = new Card(deck[i]);
                return temp;
            }
        }
        return null;
    }

   

}
