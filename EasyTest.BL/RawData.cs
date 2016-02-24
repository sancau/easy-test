namespace EasyTest.BL
{
    public class RawData
    {
        public double[,] rawData;
        public string testDate;

        public RawData(double[,] array, string date)
        {
            this.rawData = array;
            this.testDate = date;
        }
    }
}
