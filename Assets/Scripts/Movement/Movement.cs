namespace Movement
{
    public interface Movement
    {
        void MoveForward();
        void MoveBackwards();

        void StrafeLeft();
        void StrafeRight();

        void Jump();

        void TurnRight();
        void TurnLeft();
        void Turn(float axis);
    }
}