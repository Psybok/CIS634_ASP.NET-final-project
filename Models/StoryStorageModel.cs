
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Models
{
    public class StoryStorage
    {
        private StoryGet dataContext = new StoryGet();

        
        // Adds a new article to the database.
        
        public void AddArticle(StoryLink article)
        {
            dataContext.Articles.InsertOnSubmit(article);
            dataContext.SubmitChanges();
        }

        // Retrieves results, orders by date of entry.
        public IEnumerable<ArticleInformation> GetRecentArticles()
        {
            var results = from article in dataContext.Articles
                          
                          select new ArticleInformation()
                          {
                              
                              Title = article.Title,
                              Url = article.Url,
                              DateAdded = article.DateAdded,
                              
                          };

            var pageOfResults = results
                                       .OrderByDescending(r => r.DateAdded);
                                       

            return pageOfResults;
        }
    }
}
