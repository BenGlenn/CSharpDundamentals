using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>(); 

        // CRUD
        // CREATE
        public void AddContentToDirectory(StreamingContent content)
        {
            _contentDirectory.Add(content);
        }

        // READ
        // Get all streamingcontent
        public List<StreamingContent> GetDirectory()
        {
            return _contentDirectory;
        }

        // get one streamingContent By Title
        public StreamingContent GetContentByTitle(string title)
        {

            foreach (StreamingContent item in _contentDirectory)
            {
                //   if(item.Title.Contains(originalTitle)) Think about what it means to contain and the potential problems
                if (item.Title.ToLower() == title.ToLower())
                {
                    return item;
                }

            }
            return null;
        }
        // UPDATE

        public bool UpdateExistingContent(StreamingContent updatedContent, string originalTitle)
        {
            // Find the target content by originalTitle
            foreach (StreamingContent item in _contentDirectory)
            {
                //   if(item.Title.Contains(originalTitle)) Think about what it means to contain and the potential problems
                if (item.Title.ToLower() == originalTitle.ToLower())
                {
                    // Update the target content with updatedContent properties/values

                    //item.Title = updatedContent.Title;
                    //item.Description = updatedContent.Description;
                    //item.TypeGenre = updatedContent.TypeGenre;
                    //item.MaturityRating = updatedContent.MaturityRating;
                    //item.ReleaseYear = updatedContent.ReleaseYear;
                    //item.StarRating = updatedContent.StarRating;
                    //OR
                    // Find the index that item is at
                    int itemIndex = _contentDirectory.IndexOf(item);
                    // Slot in updatedContent into that index on the List
                    _contentDirectory[itemIndex] = updatedContent;

                    return true;
                }

            }

            return false;

        }

        // DELETE
        public bool DeleteExistingContent(StreamingContent content)
        {
            bool removed = _contentDirectory.Remove(content);
            return removed;
            // the shorter way of doing this return _contentDirectory.Remove(content); (hit control period)
        }

        // Delete Content by Title
        // Give a title (take in ) parameter
        // Find the content by its title 
        // If I find that content, delete 
        // return a true/false wether it worked or not


        public bool DeleteContentByTitle(string title)
        {
            StreamingContent targetContent = GetContentByTitle(title);
            return DeleteExistingContent(targetContent);
        }

    }
}
