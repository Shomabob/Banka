using Microsoft.EntityFrameworkCore.SqlServer;
using System.Net;
using System.Xml.Serialization;

namespace BankaLogic

{
    public static class MethodClass
    {
        public static List<User> GetUsers()
        {
            using (DemoTaskContext context = new DemoTaskContext())
            {
                return context.Users.ToList();
            }
        }

        public static bool UserAuth(string login, string password)
        {
            using (DemoTaskContext context = new DemoTaskContext())
            {
                var Poisk = context.Users.FirstOrDefault(Mama => Mama.Login == login && Mama.Password == password);

                if (Poisk != null)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool Registration(User user)
        {
            using (DemoTaskContext context = new DemoTaskContext())
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }
            }
        }
        public static ValCurs GetvalCurs()
        {
            WebClient webClient = new WebClient();
            var Xml = webClient.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
            using(TextReader reader = new StringReader(Xml))
            {
                return (ValCurs)xmlSerializer.Deserialize(reader);
            }

        }
                
   } 


}       //Data Source = DESKTOP - 29U9FO1\BABUN;Initial Catalog = Demo_Task; Integrated Security = True
        //"Server=DESKTOP - 29U9FO1\BABUN;Database=Demo_Task;Trusted_Connection=True;Trust Server Certificate=True;"
    


