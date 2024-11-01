using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardUI : MonoBehaviour, IPointerDownHandler
{
    public Image chr;
    public Text cardName;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // 카드= 정보 초기화
    public void CardUISet(Card card)
    {
        chr.sprite = card.cardImage;
        cardName.text = card.cardName;
    }
    // 뒤집는거
    public void OnPointerDown(PointerEventData eventData)
    {
        animator.SetTrigger("Flip");
    }
}
