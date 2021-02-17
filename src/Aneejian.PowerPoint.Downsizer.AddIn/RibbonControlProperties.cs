﻿namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal class RibbonControlProperties
    {
        public string Label { get; set; }
        public string Description { get; set; }
        public object Image { get; set; }
        public string Screentip { get; set; }
        public string Supertip { get; set; }

        public RibbonControlProperties(string label, string description, object image, string screentip = null, string supertip = null)
        {
            Label = label;
            Description = description;
            Image = image;
            Screentip = screentip ?? label;
            Supertip = supertip ?? description;
        }
    }
}