namespace ProblemVisualizer;

public class ProblemVisualizerSnapshots<TDrawerData> 
    : List<TDrawerData>
    where TDrawerData : ICloneable
{
    private int _currentSnapshotId;

    public TDrawerData Next()
    {
        if (_currentSnapshotId < Count - 1)
            _currentSnapshotId++;
        return this[_currentSnapshotId];
    }

    public TDrawerData Back()
    {
        if (_currentSnapshotId > 0)
            _currentSnapshotId--;
        return this[_currentSnapshotId];
    }

    public TDrawerData GoStart()
    {
        _currentSnapshotId = 0;
        return this[_currentSnapshotId];
    }

    public TDrawerData GoEnd()
    {
        _currentSnapshotId = Count - 1;
        return this[_currentSnapshotId];
    }

    public int GetCurrentSnapshotId() => _currentSnapshotId;

    public TDrawerData GetCurrentSnapshot() => this[_currentSnapshotId];
}