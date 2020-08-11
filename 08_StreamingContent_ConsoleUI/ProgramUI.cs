using _06_RepositoryPattern_Repository;
using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    public class ProgramUI
    {

        private bool _isRunning = true;
        private readonly IConsole _console;
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        // Constructor with injected Iconsole dependency
        public ProgramUI(IConsole console)
        {
            // Assigning our injected IConsole to our IConsole field
            _console = console;
        }

        // Entry point to our UI, is starts our user interface
        public void Start()
        {
            SeedContentList();
            RunMenu();
        }

        // This Method has the task of running the menu
        private void RunMenu()
        {
            while (_isRunning)
            {

                string userInput = GetMenuSelection();
                OpenMenuItem(userInput); // WHY DOES THIS GO HERE AND NOT ON LIN 49???
            }
        }

        private string GetMenuSelection()
        {
            _console.Clear();
            _console.WriteLine(
                          "Welcome to the Streaming Content Management!\n" +
                          "Select Menue Item:\n" +
                          "1. Show All Streaming Conent.\n" +
                          "2. Find Streaming Content.\n" +
                          "3. Add New Streaming Content.\n" +
                          "4. Update Existing Streaming Content.\n" +
                          "5. Remove Streaming Content.\n" +
                          "6. Exit");
            string userInput = _console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            _console.Clear();
            switch (userInput)
            {
                case "1":
                    DisplayAllContent();
                    break;
                case "2":
                    DisplayContentByTitle();
                    break;
                case "3":
                    CreateNewContent();
                    // Add New Content
                    break;
                case "4":
                    // Update Content
                    break;
                case "5":
                    // Remove Content
                    break;
                case "6":
                    _isRunning = false;
                    return;
                default:
                    break;
            }
            _console.WriteLine("Press a key to return to the menu...");
            _console.ReadKey();
            return;
        }


        // Show All Content
        private void DisplayAllContent()
        {
            //Get content
            //Go to the repository and get the directory
            List<StreamingContent> listOfContent = _streamingRepo.GetDirectory();

            //Display Content
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n " +
                $"Star Rating: {content.StarRating}\n " +
                $"Release Year: {content.ReleaseYear}\n " +
                $"Maturity Rating: {content.MaturityRating}\n " +
                $"Family Friendly: {(content.IsFamilyFriendly ? "Yes it is!" : "No it's not.")}\n");
        }


        // Find Content by Title

        private void DisplayContentByTitle()
        {
            // Prompt the user to give us a title 

            _console.Write("Enter a title: ");

            // Get and store the useer's input
            string title = _console.ReadLine();

            // Find the matching congtent in the repository
            StreamingContent searchResult = _streamingRepo.GetContentByTitle(title);

            // Display the content to the console
            if (searchResult != null)
            {
                DisplayContent(searchResult);
            }

            // If there is no content found, go ahead and say so 
            else
            {
                _console.WriteLine("Invalid title. Coould not find any results.");
            }

        }

        // Add New Content
        private void CreateNewContent()
        {
            // Gather the values for all the properties for the StreamingContent objects
            // Title 
            _console.Write("Enter a title:");
            string title = _console.ReadLine();


            // Description
            _console.Write("Enter a description:");
            string description = _console.ReadLine();

            // MaturityRating 
            //   G,
            MaturityRating maturityRating = GetMaurityRating();



            // StarRating
            _console.Write("Enter the star rating (1-5): ");
            double starRating = double.Parse(_console.ReadLine());

            // Release Year
            _console.Write("Enter the release year: ");
            int realeaseYear = int.Parse(_console.ReadLine());



            // GenreType 
            GenreType genre = GetGenreType();

            // Construct a StreamingContent object given the above values 
            StreamingContent newContent = new StreamingContent(title, description, maturityRating, starRating, realeaseYear, genre);

            // Add the streamingContent object to the repository ("Save" the content)
            _streamingRepo.AddContentToDirectory(newContent);
        }

        private MaturityRating GetMaurityRating()
        {
            // MaturityRating 
            _console.WriteLine("Select a Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. TV Y\n" +
                "4. PG13\n" +
                "5. R\n" +
                "6. NC17\n" +
                "7. TV PG\n" +
                "8. TV 14\n" +
                "9. TV MA");

            string maturityString = _console.ReadLine();
            // MaturityRating maturityRating;

            while (true)
            {

                switch (maturityString)
                {
                    case "1":
                        return MaturityRating.G;

                    case "2":
                        return MaturityRating.PG;

                    case "3":
                        return MaturityRating.TV_Y;

                    case "4":
                        return MaturityRating.PG13;

                    case "5":
                        return MaturityRating.R;

                    case "6":
                        return MaturityRating.NC17;

                    case "7":
                        return MaturityRating.TV_PG;

                    case "8":
                        return MaturityRating.TV_14;

                    case "9":
                        return MaturityRating.TV_MA;

                }

                _console.WriteLine("Invalid selection. Please try again");
            }
        }


        private GenreType GetGenreType()
        {
            _console.WriteLine("Select a Genre:\n" +
                "1. Action/Adventrue\n" +
                "2. Thriller\n" +
                "3. Horror\n" +
                "4. Comedy\n" +
                "5. Bromance\n" +
                "6. Mystery\n" +
                "7. Scifi\n");
            while (true)
            {
                //string genreString = _console.ReadLine();
                //int genreId = int.Parse(genreString);
                //GenreType genre = (GenreType)genreId - 1;
                //return genre;

                string genreString = _console.ReadLine();
                bool parseResult = int.TryParse(genreString, out int parsedNumber);
                if (parseResult && parsedNumber >=1 && parsedNumber <9)
                {
                    GenreType genre = (GenreType)parsedNumber - 1;
                    return genre;
                }

                if (int.TryParse(_console.ReadLine(), out int genreld))
                {
                    return (GenreType)genreld;
                }
                _console.WriteLine("Invalid selection. Please try again.");
            }

        }


        // Update Content

        // Remove Content


        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tyre comes to life and kills people.", MaturityRating.R, 5.8, 2010, GenreType.Thriller);
            StreamingContent toyStory = new StreamingContent("Toy Story", "Wonderful childhood memory.", MaturityRating.G, 10, 1995, GenreType.Bromance);
            StreamingContent helloKitty = new StreamingContent("Hello Kitty Island Adventure", "Insert description here.", MaturityRating.R, 8.9, 1973, GenreType.Horror);

            _streamingRepo.AddContentToDirectory(rubber);
            _streamingRepo.AddContentToDirectory(toyStory);
            _streamingRepo.AddContentToDirectory(helloKitty);

        }

    }
}




