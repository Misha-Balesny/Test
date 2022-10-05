using System.Text.Json.Serialization;

namespace test
{
    internal class UserModel
    {
        public int AvgSteps { get; set; }
        public int Best { get; set; }
        public int Worst { get; set; }
        public string User { get; set; }
        public DayInfo[] DayInfo { get; set; }
        [JsonIgnore]
        public string Color { get; set; }

        public UserModel() 
        {
            DayInfo = new DayInfo[30];
        }
        public void CountNumbers()
        {
            int sum = 0;
            Best = 0;
            Worst = 999999999;
            foreach (var item in DayInfo)
            {
                if (item.Steps > Best)
                {
                    this.Best = item.Steps;
                }
                if (item.Steps < Worst)
                {
                    this.Worst = item.Steps;
                }
                sum += item.Steps;
            }
            this.AvgSteps = sum/30;
        }
    }
}
