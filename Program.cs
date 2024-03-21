using System;

namespace Magazine
    {
    abstract class Magazine
        {
        // Properties
        public abstract string Name { get; set; }
        // Methods
        public abstract string Specs();
        }

    class Program
        {
        class Fashion : Magazine
            {
            // override the abstract property
            public override string Name { get; set; }
            public string Publisher { get; set; }
            public string IssueMonth { get; set; }
            public string IssueYear { get; set; }
            public string CoverStory { get; set; }
            public int NumberOfPages { get; set; }

            public Fashion()
                {
                Name = string.Empty;
                Publisher = string.Empty;
                IssueMonth = string.Empty;
                IssueYear = string.Empty;
                CoverStory = string.Empty;
                NumberOfPages = 0;
                }
            public Fashion(string name, string publisher, string issueMonth, string issueYear, string coverStory, int numberOfPages)
                {
                Name = name;
                Publisher = publisher;
                IssueMonth = issueMonth;
                IssueYear = issueYear;
                CoverStory = coverStory;
                NumberOfPages = numberOfPages;
                }

            // override the abstract method 
            public override string Specs()
                {
                return "Fashion Magazine Info: ";
                }
            public string Describe()
                {
                    return Name + "\nPublisher: " + Publisher + "\nIssue: " + IssueMonth + IssueYear + "\nCover Story: " + CoverStory + "\nNumber of Pages: " + NumberOfPages;
                }
            }//end of Fashion class
        static void Main(string[] args)
            {
            // Create Fashion object using default constructor
            Fashion vogue = new Fashion();
            vogue.Name = "Vogue";
            vogue.Publisher = "Condé Nast";
            vogue.IssueMonth = "March";
            vogue.IssueYear = "2024";
            vogue.CoverStory = "Legendary! 40 Vogue Icons, 1 Epic Shoot... The Ultimate Fashion Issue.";
            vogue.NumberOfPages = 39;

            //create Fashion object using paramaterized constructor
            Fashion elle = new Fashion("Elle", "Hearst", "February", "2024", "The Original Mother - Penelope Cruz", 120);

            //Display methods
            Console.WriteLine(vogue.Specs());
            Console.WriteLine(vogue.Describe());
            Console.WriteLine();
            Console.WriteLine(elle.Specs());
            Console.WriteLine(elle.Describe());


            }  //end of Main method  
        }//end of Program class
    }//end of AbstractAnimalClass namespace
