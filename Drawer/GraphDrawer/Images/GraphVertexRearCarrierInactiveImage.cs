using Microsoft.AspNetCore.Components;

namespace Plaszczakowo.Drawer.GraphDrawer.Images;

public class GraphVertexRearCarrierInactiveImage : GraphVertexImage
{
    public override bool GetOnVertex()
    {
        return true;
    }

    protected override ElementReference GetImageReferenceFromProvider(IGraphVertexImageProvider provider)
    {
        return provider.RearCarrierInactive;
    }
}