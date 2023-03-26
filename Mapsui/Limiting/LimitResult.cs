﻿namespace Mapsui.Limiting;
public class LimitResult
{
    public LimitResult(Viewport input, Viewport output)
    {
        ZoomLimited = input.Resolution != output.Resolution;
        PanXLimited = input.CenterX != output.CenterX;
        PanYLimited = input.CenterY != output.CenterY;
        FullyLimited = ZoomLimited && PanXLimited && PanYLimited;
    }

    public bool ZoomLimited { get; }
    public bool PanXLimited { get; }
    public bool PanYLimited { get; }
    public bool FullyLimited { get; }

}