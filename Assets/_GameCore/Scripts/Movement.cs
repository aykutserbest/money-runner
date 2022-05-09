using UnityEngine;

namespace _GameCore.Scripts
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float clampxMin = -2.7f;
        [SerializeField] private float clampxMax = 0.7f;
        
        void Update()
        {
            MovementAddDirection(Input.GetAxis("Horizontal"));
         
        }

        private void MovementAddDirection(float direction)
        {
            transform.Translate(-direction * speed * Time.deltaTime, 0, -1 * speed * Time.deltaTime);
            
            Vector3 clampedPosition = transform.position;
            
            clampedPosition.x= Mathf.Clamp(clampedPosition.x, clampxMin, clampxMax);
            
            transform.position = clampedPosition;
        }
    }
}
