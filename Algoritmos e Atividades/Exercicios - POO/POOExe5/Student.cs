namespace POOExe5
{
    public class Student
    {
        public string Name;
        public double Note1, Note2, Note3;

        public double Result()
        {
            return Note1 + Note2 + Note3;
        }

        public bool Aproved()
        {
            if (Result() >= 60.0)
                return true;
            else
                return false;
        }

        public double RemainingNote()
        {
            if (Aproved())
                return 0.0;
            else
                return 60.0 - Result();
        }
    }
}