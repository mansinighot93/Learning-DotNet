namespace MySqlTestApp
{
    public class Book
    {
        public string ISBN {get;set;}
        public string Title {get;set;}
        public string Auther {get;set;}
        public string Language {get;set;}
        public int Pages {get;set;}
        public virtual Publisher Publisher{get;set;}
    }
}