using System;
namespace Recuritment
{
    public class Resume
    {
        public string Name{get;set;}
        public string Email{get;set;}
        public string Content{get;set;}

        public override string ToString()
        {
            return "Resume [email=" + Email + ", Name =" + Name  + ", Content =" + Content + "]";
        }
    }

    //Singleton class
    public class JobPortal
    {
        private static JobPortal portal = new JobPortal();
        private List<Resume> resumeList = new List<Resume>();
        private JobPortal()
        {

        }
        public static JobPortal GetJob()
        {
            return portal;
        }

        public void uploadContent(string mail,string name,string content)
        {
            Resume resume = new Resume();
            resume.Name = name;
            resume.Email = mail;
            resume.Content = content;

            resumeList.Add(resume);
        }

        public void triggerCampusing()
        {
            foreach(Resume resume in resumeList)
            {
                Console.WriteLine("Sending mail to " + resume.Name + "at" + resume.Email);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            //Don't call us,we will call you
            JobPortal.get().uploadContent("manasinighot@gmail.com","Manasi Nighot","A C# Develeoper");
            JobPortal.get().uploadContent("ajinkya@gmail.com","Ajinkya Nighot","A C# Develeoper");
            JobPortal.get().uploadContent("rutuja@gmail.com","Rutuja Tambade","A C# Develeoper");
            JobPortal.get().uploadContent("divya@gmail.com","Divya Bhor","A C# Develeoper");
            JobPortal.get().triggerCampusing();
        }
    }
}