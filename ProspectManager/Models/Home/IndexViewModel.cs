using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProspectManager.Models.Meetings;
using ProspectManager.Models.TodoItems;

namespace ProspectManager.Models.Home
{
    public class IndexViewModel
    {
        public List<TodoItem> UpcomingTodos { get; set; }

        public List<Meeting> UpcomingMeetings { get; set; }

        public List<char> Alphabet { get; set; }
    }
}