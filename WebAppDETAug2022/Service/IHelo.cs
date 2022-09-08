namespace WebAppDETAug2022.Service
{
    public interface IHelo
    {
        string SayHelo(string name);
    }

    public class Helo1 : IHelo
    {
        public string SayHelo(string name)
        {
            return ($"Hello {name}, Welcdome to ASP.Net Core");
        }
    }

    public class Helo2 :IHelo
    {
        public string SayHelo(string name)
        {
            return ($"Hai, Hello {name}, Welcome to ASP.Net Core");
        }
    }
}
