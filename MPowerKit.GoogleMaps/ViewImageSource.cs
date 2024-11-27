﻿namespace MPowerKit.GoogleMaps;

public interface IViewImageSource : IImageSource
{
    View? View { get; }
}

public class ViewImageSource : ImageSource, IViewImageSource
{
    public View? View { get; set; }

    public override bool IsEmpty => View is null;
}