using System;

namespace StackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var Post = new Post();

            Console.WriteLine(Post.CreatePost("silly question", "how do i add a method?"));
            Console.WriteLine(Post.UpVote());
            Console.WriteLine(Post.UpVote());

            Console.WriteLine(Post.UpVote());
            Console.WriteLine(Post.UpVote());
            Console.WriteLine(Post.UpVote());

            Console.WriteLine(Post.DownVote());

        }
    }
}
