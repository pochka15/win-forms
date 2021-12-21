#nullable enable
using System;
using System.Collections.Generic;
using lab.track;

namespace lab {
public class MusicFormState {
    private readonly TracksState _parentState;
    public event Action<TrackDto>? TrackAdded;
    public event Action<TrackDto>? TrackDeleted;
    public event Action<TrackDto, TrackDto>? TrackUpdated;

    public IEnumerable<TrackDto> Tracks => _parentState.Tracks;
    public TrackDto? SelectedTrack { get; set; }

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
}
}