using System;
using System.Collections.Generic;
using System.Linq;

namespace lab.track {
public class TracksState {
    public event Action<TrackDto> TrackAdded;

    private readonly List<Track> _tracks;

    public IEnumerable<TrackDto> Tracks => _tracks.Select(it => it.ToDto());

    public TracksState(List<Track> tracks) {
        _tracks = tracks;
    }

    public void AddTrack(Track track) {
        _tracks.Add(track);
        TrackAdded?.Invoke(track.ToDto());
    }


    // ReSharper disable once MemberCanBePrivate.Global
    public static Track DummyTrack(int index) {
        return new Track {
            Name = "Track " + index,
            Author = "Author " + index,
            Category = "Category " + index,
            CreatedAt = new DateTime(1996, 6, 3, 22, 15, 0)
        };
    }

    public static List<Track> BuildDummyTracks(int amount) {
        var items = new List<Track>();
        for (var i = 0; i < amount; i++) {
            items.Add(DummyTrack(i + 1));
        }

        return items;
    }
}
}