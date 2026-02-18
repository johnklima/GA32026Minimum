using UnityEngine;
using UnityEngine.UI;
public class MouseOverTooltip : MonoBehaviour
{

    public Text text;

    

    public void ShowToolTip(bool onoff)
    {
        text.gameObject.SetActive(onoff);
    }
}
