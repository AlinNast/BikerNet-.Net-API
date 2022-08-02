namespace BikerNetApi
{
    public class FeedPost
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public DateTime Created { get; set; }

        public Guid? UserId { get; set; }

        public string? Image { get; set; }

        public string? Location { get; set; }
    }
}
