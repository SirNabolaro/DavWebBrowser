﻿namespace DavWebCreator.Clients.ClientModels.Browser.Elements
{
    public interface IBrowserFont
    {
        string FontFamily { get; set; }
        string FontSize { get; set; }
        string FontColor { get; set; }
        bool Bold { get; set; }
    }
}
