namespace StaticClassDemo
{
    public class CommonTask
    {
        public bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }
            return false;
        }
        public string GetComputerName()
        {
            return System.Environment.MachineName;
        }
    }
}