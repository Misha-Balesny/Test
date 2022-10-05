using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace test
{
    internal class FileHandler
    {
        public static DayInfo[] GetDayInfos(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            DayInfo[] dayInfo = JsonSerializer.Deserialize<DayInfo[]>(fs);
            fs.Close();
            return dayInfo;
        }

        public static void SaveUserInfo(UserModel user)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            FileStream fs = new FileStream("user.json", FileMode.Create);
            JsonSerializer.Serialize<UserModel>(fs, user, options);
            fs.Close(); 
        }

        public static UserModel[] CreateUsers()
        {
            var collection = GetDayInfos("day1.json");
            UserModel[] users = new UserModel[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                users[i] = new UserModel();
                users[i].User = collection[i].User;
            }
            FillUserData(users);
            return users;
        }

        public static UserModel[] FillUserData(UserModel[] collection)
        {            
            for (int i = 0; i < 30; i++)
            {
                var dayInfo = GetDayInfos($"day{i+1}.json");
                foreach (UserModel item in collection)
                {
                    DayInfo[] userDayInfo = (from day in dayInfo where day.User==item.User select day).ToArray();
                    if (userDayInfo.Length == 0)
                    {
                        item.DayInfo[i] = new DayInfo() { Rank = 0, Status = "", Steps = 0, User = item.User };
                    }
                    else
                    {
                        item.DayInfo[i] = userDayInfo[0];
                    }                    
                }
            }
            foreach (UserModel item in collection)
            {
                item.CountNumbers();
            }
            return collection;
        }
    }
}
