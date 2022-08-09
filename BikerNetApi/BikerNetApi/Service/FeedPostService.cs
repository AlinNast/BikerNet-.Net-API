﻿using BikerNetApi.Models;
using BikerNetApi.Repository;

namespace BikerNetApi.Service
{
    public class FeedPostService : IFeedPostService
    {
        private IFeedPostRepository _postsRepo;

        public FeedPostService(IFeedPostRepository postsRepo)
        {
            _postsRepo = postsRepo;
        }

        public async Task<List<FeedPost>> GetAllPosts()
        {
            var posts = await _postsRepo.GetAllPosts();
            return posts;
        }

        public async Task<FeedPost> GetPost(Guid id)
        {
            var posts = await _postsRepo.GetAllPosts();
            var post = posts.Find(x => x.Id == id);
            return post;
        }

        public void CreatePost(FeedPost post)
        {
            _postsRepo.CreatePost(post);
        }

        public void EditPost(FeedPost editedPost)
        {
            _postsRepo.EditPost(editedPost);
        }

        public void DeletePost(Guid id)
        {
            _postsRepo.DeletePost(id);
        }
    }
}
