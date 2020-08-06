﻿using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    class ProgramUI
    {

        private bool _isRunning = true;
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

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
               
                string userImput = GetMenuSelection();
                OpenMenuItem(userImput);
            }
        }

        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine(
                          "Welcome to the Streaming Content Management!\n" +
                          "Select Menue Item:\n" +
                          "1. Show All Streaming Conent.\n" +
                          "2. Find Streaming Content.\n" +
                          "3. Add New Streaming Content.\n" +
                          "4. Update Existing Streaming Content.\n" +
                          "5. Remove Streaming Content.\n" +
                          "6. Exit");
            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    DisplayAllContent();
                    Console.WriteLine("Press a key to return to the menu...");
                    Console.ReadKey();
                    break;
                case "2":
                    // Find Content by Title
                    break;
                case "3":
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
                    break;
                default:
                    break;
            }
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
            Console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n " +
                $"Star Rating: {content.StarRating}\n " +
                $"Release Year: {content.ReleaseYear}\n " +
                $"Maturity Rating: {content.MaturityRating}\n " +
                $"Family Friendly: {(content.IsFamilyFriendly ? "Yes it is!" : "No it's not.")}\n");
        }


        // Find Content by Title

        // Add New Content

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



