using Plaszczakowo.Drawer;
using Plaszczakowo.ProblemVisualizer;

namespace Plaszczakowo.ProblemResolver;

public class ProblemRecreationCommands<TDrawData>
    where TDrawData : DrawerData
{
    public List<ProblemVisualizerCommandsQueue<TDrawData>> Commands = [new ProblemVisualizerCommandsQueue<TDrawData>()];

    public void NextStep()
    {
        Commands.Add(new ProblemVisualizerCommandsQueue<TDrawData>());
    }

    public void Add(ProblemVisualizerCommand<TDrawData> command)
    {
        Commands.Last().Enqueue(command);
    }
}