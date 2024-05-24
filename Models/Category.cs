using System.Text.Json.Serialization;

namespace ForumApi.Models
{
    public class Category
    {
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("kategoryname")]
        public string? KategoryName { get; set; }
    }
}
