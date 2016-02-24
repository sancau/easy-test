namespace EasyTest.BL
{
    /// <summary>
    /// Класс собирает данные введенные пользователем
    /// в объект, для последущей передачи их в класс ReportCreator
    /// для создания отчета
    /// </summary>
    public class UserInput
    {
        public string filePath;

        public double channelCount;
        public double checksCount;
        public double targetValue;
        public double dtNormal;
        public double tKT;
        public double tIU;

        public string specialistName;
        public string headName;
        public string chamberName;
        public string reportDir;

        public int[] chosenChannels;
        public int startIndex;
    }
}
