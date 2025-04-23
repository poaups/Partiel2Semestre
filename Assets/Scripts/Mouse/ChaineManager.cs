using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChaineManager : MonoBehaviour
{
    [field:SerializeField]
    public bool IsDraging { get; private set; }
    [field: SerializeField]
    public string LastBall { get; private set; }
    [field: SerializeField]
    public string LastMouseLeft { get; private set; }

    [Header("Debug texte")]
    [SerializeField] private TextMeshProUGUI debugTxtEnter;
    [SerializeField] private string debugTextBeforeEnter;

    [SerializeField] private TextMeshProUGUI debugTxtDrag;
    [SerializeField] private string debugTextBeforeDrag;
    private void Awake()
    {
        IsDraging = false;
    }
    public void LastEnter(string name)
    {
        LastBall = name;
        debugTxtEnter.text = debugTextBeforeEnter + name;
    }

    public void LastDrag(string name)
    {
        SetDraging(true);
        print("LastDrag");
        LastMouseLeft = name;
        debugTxtDrag.text = debugTextBeforeDrag + name;
        Combo();
    }
    void ResetLastDrag()
    {
        LastMouseLeft = "";
        debugTxtDrag.text = debugTextBeforeDrag + "";
    }
    public void CancelDrag()
    {
        SetDraging(false);
        print("CancelDrag + " + IsDraging);
    }

    void Combo()
    {

    }
    void SetDraging(bool newDraging)
    {
        IsDraging = newDraging;
    }
}
