using Drawer;
using Microsoft.AspNetCore.Components;
using ProblemVisualizer;

namespace ProjektZaliczeniowy_AiSD2.Components.Shared.Visualizer;

public abstract class VisualizerComponentBase<TDrawerData> : ComponentBase
    where TDrawerData : DrawerData
{
    [Parameter] public required ProblemVisualizerSnapshots<TDrawerData> Snapshots { get; set; }

    protected abstract void OnSnapshotChange(TDrawerData newDrawerData);
}