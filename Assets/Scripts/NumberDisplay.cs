using UnityEngine;
using TMPro;

namespace BouncingBalls
{
    public class NumberDisplay : MonoBehaviour
    {
        public TextMeshProUGUI numberText;

        public void SetNumber(int number)
        {
            numberText.text = number.ToString();

            Renderer renderer = GetComponent<Renderer>();
            Material material = renderer.material;

            if (number % 3 == 0 && number % 5 == 0)
            {
                material.color = Color.magenta; // Purple :D
            }
            else if (number % 3 == 0)
            {
                material.color = Color.red;
            }
            else if (number % 5 == 0)
            {
                material.color = Color.blue;
            }
            else
            {
                material.color = Color.gray;
            }
        }
    }
}