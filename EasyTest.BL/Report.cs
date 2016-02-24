namespace EasyTest.BL
{
    public class Report
    {
        public double[,] reportArray;
        public double[] avgArray;

        public double dtNormal; 
        public double targetValue; 
        public double maxAmp;
        public double dT1;
        public double dT2;
        public double dIU;
        public double tNer;
        public double delta;

        public bool testPassed;
        public bool reportCreated;

        public string summary; 
        public string date; 
        public string specialistName; 
        public string headName; 
        public string resolution;
        public string chamberName;
    }
}
