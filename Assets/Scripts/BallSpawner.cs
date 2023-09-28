using UnityEngine;

namespace BouncingBalls
{
    public class BallSpawner : MonoBehaviour
    {
        public GameObject ballPrefab;
        public int numberOfBalls = 50;

        void Start()
        {
            for (int i = 1; i <= numberOfBalls; i++)
            {
                GameObject ball = Instantiate(ballPrefab, new Vector3(i * 2, 5, 0), Quaternion.identity);
                ball.name = "Ball_" + i.ToString();
                NumberDisplay numberDisplay = ball.GetComponent<NumberDisplay>();
                numberDisplay.SetNumber(i);
            }
        }
    }
}