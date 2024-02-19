using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
     [SerializeField] private TextMeshProUGUI m_text;
     private int m_counter;

     public void IncreaceCounter()
     {
         m_counter++;
         m_text.text = m_counter.ToString();
     }
}
