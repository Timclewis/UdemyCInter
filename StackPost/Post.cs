using System;
namespace StackPost
{
    public class Post
    {
        // properties
        public int _id { get; set; }
        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _timeCreated { get; set; }
        private int _upvote { get; set; }
        private int _downvote { get; set; }
        private double _voteTotal { get; set; }

        // methods
        public string CreatePost(string title, string description)
        {
            _id += 1;
            _title = title;
            _description = description;
            _timeCreated = DateTime.Now;

            return String.Format("Title: {0} \nDescription: {1} \nDate posted: {2}", title, description, _timeCreated);
        }

        public string UpVote()
        {
            _upvote += 1;
            _voteTotal = _upvote - _downvote;
            return String.Format("Points Score! {0}", _voteTotal);
        }

        public string DownVote()
        {
            _downvote += 1;
            _voteTotal = _upvote - _downvote;
            return String.Format("Points Score! {0}", _voteTotal);
        }


    }
}
