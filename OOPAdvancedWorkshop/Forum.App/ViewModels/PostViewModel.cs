namespace Forum.App.ViewModels
{
    using Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class PostViewModel : ContentViewModel, IPostViewModel
    {
        public PostViewModel(string title, string author, string content, IEnumerable<IReplyViewModel> replies) : base(content)
        {
            this.Title = title;
            this.Author = author;
            this.Replies = replies.ToArray();
        }

        public string Title { get; }

        public string Author { get; }

        public IReplyViewModel[] Replies { get; }
    }
}
