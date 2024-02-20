using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
   public static KillCounter Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI m_text;

    private int m_counter;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Duplicate singleton instance of KillCounter!");
            Destroy(gameObject); // Destroy the duplicate instance
            return;
        }

        Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void IncreaseCounter()
    {
        ++m_counter;
        if (m_text != null)
        {
            m_text.text = m_counter.ToString();
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI reference is missing!");
        }
    }
}
