using UnityEngine;

namespace Assets.Scripts
{
    class ParralaxLayerScrolling : MonoBehaviour
    {
        /// <summary>
        /// The background layers
        /// </summary>
        public GameObject[] Layers;

        /// <summary>
        /// The speed of the first layer (most back)
        /// </summary>
        public float StartSpeed = 1f;

        /// <summary>
        /// The increasement of speed per layer from the first (most back)
        /// </summary>
        public float SpeedIncreasement = 0.1f;

        public void Update()
        {
            // Move All Layers
            int layers = Layers.Length;
            if (layers > 0)
            {
                for (int i = 0; i < layers; i++)
                {
                    // Calculate speed for current layer
                    float xSpeed = (StartSpeed + SpeedIncreasement * i) * Time.deltaTime;
                    // Apply speed to layer
                    Layers[i].transform.Translate(new Vector3(xSpeed, 0, 0));
                }
            }
        }

    }
}
