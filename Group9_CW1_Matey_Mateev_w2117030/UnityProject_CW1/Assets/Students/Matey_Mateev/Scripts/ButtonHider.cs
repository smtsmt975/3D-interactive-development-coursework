using UnityEngine;

//w2117030 Matey Mateev
public class ButtonVisibility : MonoBehaviour
{
    public GameObject walk;

    
    public void ShowWalkButton() // shows walk/stand button
    {
        walk.SetActive(true);
    }

  
    public void HideWalkButton() //hides walk/stand button
    {
        walk.SetActive(false);
    }
}