using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length; // in seconds
        private List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public string GetTitle() => _title;
        public string GetAuthor() => _author;
        public int GetLength() => _length;
        public List<Comment> GetComments() => _comments;

        public string GetFormattedLength()
        {
            int minutes = _length / 60;
            int seconds = _length % 60;
            return $"{minutes}:{seconds:D2}";
        }
    }
}