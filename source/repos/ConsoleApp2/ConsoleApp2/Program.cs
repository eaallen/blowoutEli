using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach(Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach(Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }

            }
            Console.ReadKey();
        }
    }

    abstract class Page { }
    class SkillsPage : Page { }
    class EducationPage : Page { }
    class ExpirancePage : Page { }
    class IntroductionPage : Page { }
    class ConclusionPage : Page { }
    class SummeryPage : Page { }
    class BibliagraphyPage : Page { }

    abstract class Document
    {
        public abstract void Createpages();
        private List<Page> pages = new List<Page>();
        public Document()
        {
            this.Createpages();
        }
        public List<Page> Pages
        {
            get { return pages; }
        }

    }
    class Resume : Document
    {
        public override void Createpages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new IntroductionPage());
        }
    }
    class Report : Document
    {
        public override void Createpages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new IntroductionPage());
        }
    }

}

