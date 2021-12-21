using System;
using System.Collections.Generic;
using lab.track;

namespace lab {
public class MusicFormState {
    private readonly TracksState _parentState;
    public event Action<TrackDto> TrackAdded;

    public IEnumerable<TrackDto> Tracks => _parentState.Tracks;

    public MusicFormState(TracksState parentState) {
        _parentState = parentState;
        _parentState.TrackAdded += track => TrackAdded?.Invoke(track);
    }
}
}