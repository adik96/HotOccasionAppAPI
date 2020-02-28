
namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class CommentDTO
    {
        #region Properties
        public long Id { get; set; }
        public string Text { get; set; }
        public string AuthorId { get; set; }
        public long OccasionId { get; set; }

        public UserDTO Author { get; set; }
        public OccasionDTO Occasion { get; set; }
        #endregion
    }
}
