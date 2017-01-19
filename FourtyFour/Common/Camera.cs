using Microsoft.Xna.Framework;

namespace FourtyFour.Common
{
    public class Camera
    {
        public  Matrix Projection { get; }

        public Matrix View { get; private set; }

        private Vector3 _position;

        public Vector3 Position
        {
            get { return _position; }
            set
            {
                _position = value;
                View = Matrix.CreateLookAt(Position, Vector3.Zero, Vector3.Up);
            }
        }

        public Camera(float fov, float aspectRatio, float nearPlane, float farPlane)
        {
            Projection = Matrix.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlane, farPlane);
        }
    }
}
