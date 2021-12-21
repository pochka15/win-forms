using System;
using lab.track;

namespace lab {
public class DialogState {
    public string Name { get; set; }
    public string Author { get; set; } = "";
    public string Category { get; set; } = "";
    public DateTime CreatedAt { get; set; }

    public Track ToTrackModel() {
        return new Track {
            Name = Name,
            Author = Author,
            Category = Category,
            CreatedAt = CreatedAt
        };
    }

    public TrackDto ToTrackDto() {
        return new TrackDto {
            Name = Name,
            Author = Author,
            Category = Category,
            CreatedAt = CreatedAt
        };
    }
}
}