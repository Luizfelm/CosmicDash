using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [HideInInspector] public int points = 0;
    [HideInInspector] public int lifes = 3;

    public TextMeshProUGUI pointText;
    public GameObject[] lifeIcons;    

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        pointText.text = points.ToString();
    }

    public void RemoveLife(int lifes)
    {
        this.lifes -= lifes;
        lifeIcons[this.lifes].SetActive(false);
    }
}
