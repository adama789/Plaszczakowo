using Microsoft.AspNetCore.Components;

namespace Drawer.GraphDrawer;

public class GraphVertexFactoryImage : GraphVertexImage
{
    public override bool GetOnVertex()
        => false;

    protected override ElementReference GetImageReferenceFromProvider(IGraphVertexImageProvider provider)
    {
        return provider.Factory;
    }
    
}