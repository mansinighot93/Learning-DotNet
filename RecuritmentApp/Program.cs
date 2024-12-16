using System;

namespace Recuritment
{
    // Business Entity
    public class Resume
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return "Resume [email=" + Email + ", Name=" + Name + ", Content=" + Content + "]";
        }
    }

    // Singleton class
    // Business Process Management
    public class JobPortal
    {
        //1.Define portal as static variablefor class and initialize
        //2.Always invoked
        //3.Always invoked instance through static method
        //Static variable 
        
        private static JobPortal portal = new JobPortal();
        private List<Resume> resumeList = new List<Resume>();
        
        //1.Private Constructor
        private JobPortal() { }

        public static JobPortal GetJob()
        {
            //refernce of instance
            return portal;
        }

        public void uploadContent(string Email, string Name, string Content)
        {
            Resume resume = new Resume();
            resume.Name = Name;
            resume.Email = Email;
            resume.Content = Content;

            resumeList.Add(resume);
        }

        public void triggerCampusing()
        {
            foreach (Resume resume in resumeList)
            {
                Console.WriteLine("Sending mail to " + resume.Name + " at " + resume.Email);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Testing
            // Don't call us, we will call you
            //Is this get function static or memeber function
            //Notify indirectly to all candidates
            //JobPortal thePortal = new JobPortal();
            //JobPortal.GetJob();
            JobPortal.GetJob().uploadContent("manasinighot@gmail.com", "Manasi Nighot", "A C# Developer");
            JobPortal.GetJob().uploadContent("ajinkya@gmail.com", "Ajinkya Nighot", "A C# Developer");
            JobPortal.GetJob().uploadContent("rutuja@gmail.com", "Rutuja Tambade", "A C# Developer");
            JobPortal.GetJob().uploadContent("divya@gmail.com", "Divya Bhor", "A C# Developer");
            
            //Initiating buissness process by one broadcast behaviour
            JobPortal.GetJob().triggerCampusing();
        }
    }
}
