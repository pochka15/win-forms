using System;

namespace lab.track {
public class Track {
    public string Name { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public DateTime CreatedAt { get; set; }

    public TrackDto ToDto() {
        return new TrackDto {
            Name = Name,
            Author = Author,
            Category = Category,
            CreatedAt = CreatedAt
        };
    }
}
}