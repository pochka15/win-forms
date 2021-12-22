#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using lab.track;

namespace lab {
public class MusicFormState {
    private readonly TracksState _parentState;
    public event Action<TrackDto>? TrackAdded;
    public event Action<TrackDto>? TrackDeleted;
    public event Action<TrackDto, TrackDto>? TrackUpdated;

    public event Action? AllTracksUpdated;

    public IEnumerable<TrackDto> Tracks => FilterTracks();

    private IEnumerable<TrackDto> FilterTracks() {
        var year2000 = new DateTime(2000, 1, 1);
        return _filter switch {
            Filter.After2000 => _parentState.Tracks
                .Where(it => it.CreatedAt > year2000),
            Filter.Before2000 => _parentState.Tracks
                .Where(it => it.CreatedAt < year2000),
            _ => _parentState.Tracks
        };
    }

    public TrackDto? SelectedTrack { get; set; }

    private Filter _filter = Filter.All;

    public MusicFormState(TracksState parentState) {
        _parentState = parentState;
        _parentState.TrackAdded += track => TrackAdded?.Invoke(track);
        _parentState.TrackDeleted += track => TrackDeleted?.Invoke(track);
        _parentState.TrackUpdated += (prev, next) => TrackUpdated?.Invoke(prev, next);
    }

    public void UpdateTrack(TrackDto prev, TrackDto next) {
        _parentState.UpdateTrack(prev, next);
    }

    public void DeleteTrack(TrackDto track) {
        _parentState.DeleteTrack(track);
    }

    public void UpdateFilter(string name) {
        var newOne = FilterUtils.Parse(name);
        if (newOne == _filter) return;
        _filter = newOne;
        AllTracksUpdated!.Invoke();
    }
}

public enum Filter {
    All,
    Before2000,
    After2000
}

public static class FilterUtils {
    public const string All = "All";
    public const string Before2000 = "Before 2000";
    public const string After2000 = "After 2000";

    public static Filter Parse(string name) {
        return name switch {
            Before2000 => Filter.Before2000,
            After2000 => Filter.After2000,
            _ => Filter.All
        };
    }

    public static string[] AllTypes() {
        return new[] {All, Before2000, After2000};
    }
}
}