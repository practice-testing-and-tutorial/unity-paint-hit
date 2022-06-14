using UnityEngine;

namespace PaintHit.Core
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Ball _ballPrefab;
        [SerializeField] private Transform _ballShootPosition;

        public void ThrowBall()
        {
            var ball = Instantiate(_ballPrefab, _ballShootPosition.position, Quaternion.identity);
            ball.Color = Color.red;
            ball.Throw();
        }
    }
}
