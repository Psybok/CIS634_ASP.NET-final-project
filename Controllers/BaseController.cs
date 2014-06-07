using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CISTermProject634.Models;
using Models;

namespace CISTermProject634.Controllers
{
    public class BaseController : Controller
    {
        private StoryStorage _storyStorage = null;
        
        public StoryStorage Storage
        {
            get
            {
                if (_storyStorage == null)
                    _storyStorage = new StoryStorage();

                return _storyStorage;
            }
        }
    }
}