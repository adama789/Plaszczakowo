namespace Drawer.GraphDrawer;

public class GraphData : ICloneable
{
    public List<GraphEdge> Edges;
    public List<GraphVertex> Vertices;

    public GraphData(List<GraphVertex> vertices, List<GraphEdge> edges)
    {
        Vertices = vertices;
        Edges = edges;
    }

    public object Clone()
    {
        return new GraphData(
            Vertices.Select(vertex => (GraphVertex)vertex.Clone()).ToList(),
            Edges.Select(edge => (GraphEdge)edge.Clone()).ToList()
        );
    }

    public GraphEdge ChangeEdgeState(int index, GraphState state)
    {
        var currentEdge = Edges[index];
        currentEdge.State = state;

        return currentEdge;
    }

    public GraphEdge ChangeEdgeFlow(int index, GraphFlow flow)
    {
        var currentEdge = Edges[index];
        currentEdge.Flow = flow;

        return currentEdge;
    }

    public GraphVertex ChangeVertexStatus(int index, GraphState state)
    {
        var currentVertex = Vertices[index];
        currentVertex.State = state;

        return currentVertex;
    }
}