using BikerNetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BikerNetApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<FeedPost> FeedPosts { get; set; }
        
    }
}
