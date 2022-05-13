using NetCore_01.Models;

namespace NetCore_01.Utils
{
    public static class PostData
    {
        private static List<Post> posts;

        public static List<Post> GetPosts()
        {
            if(PostData.posts != null)
            {
                return PostData.posts;
            }

            List<Post> NuovaListaPost = new List<Post>();
            for(int i = 0; i < 5; i++)
            {
                Post post = new Post(i, "Titolo post:" + i, "Ingredienti", "https://cookingitaly.de/wp-content/uploads/2020/02/DSC06476.jpg");
                NuovaListaPost.Add(post);
            }
            PostData.posts = NuovaListaPost;
            return PostData.posts;
        }
    }
}
