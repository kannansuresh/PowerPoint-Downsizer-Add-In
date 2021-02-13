using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class RibbonControlValues
    {
        private static readonly RibbonControlProperties Potential = new RibbonControlProperties
        (
            label: "Get Downsize Potential",
            description: "Gets the number of unused/deletable layouts and master slides in the current presentation.",
            image: "FileViewDigitalSignatures"
        );

        private static readonly RibbonControlProperties Downsize = new RibbonControlProperties
        (
            label: "Downsize Slide Master",
            description: "Removes unused layouts and master slides from the current presentation.",
            image: "DeleteSlideContextual"
        );

        private static readonly RibbonControlProperties HideTab = new RibbonControlProperties
        (
            label: "Hide Tab",
            description: "Hides the downsizer tab from PowerPoint ribbon. You can access all downsizer functionalities from View tab.",
            image: "WindowHide"
        );

        private static readonly RibbonControlProperties RevealTab = new RibbonControlProperties
        (
            label: "Reveal Tab",
            description: "Reveal downsizer tab.",
            image: "WindowUnhide"
        );

        private static readonly RibbonControlProperties Help = new RibbonControlProperties
        (
            label: "Help",
            description: "Get help and support on Downsizer Add-In.",
            image: "FunctionsLogicalInsertGallery"
        );

        private static readonly RibbonControlProperties Coffee = new RibbonControlProperties
        (
            label: "Buy a Coffee!",
            description: "Do you like the Downsizer Add-In? Consider buying a coffee for the developer!",
            image: "Coffee"
        );

        private static readonly Dictionary<string, RibbonControlProperties> ControlDictionary = new Dictionary<string, RibbonControlProperties>()
        {
            ["Potential"] = Potential,
            ["Downsize"] = Downsize,
            ["HideTab"] = HideTab,
            ["RevealTab"] = RevealTab,
            ["Help"] = Help,
            ["Coffee"] = Coffee
        };

        internal static string GetControlProperty(string tag, ControlProperties property)
        {
            if (tag == "Hide")
            {
                tag = Properties.Settings.Default.ShowDownsizerTab ? "HideTab" : "RevealTab";
            }

            var controlProperty = ControlDictionary[tag];

            switch (property)
            {
                case ControlProperties.Label:
                    return controlProperty.Label;

                case ControlProperties.Description:
                    return controlProperty.Description;

                case ControlProperties.Image:
                    return controlProperty.Image;

                case ControlProperties.Screentip:
                    return controlProperty.Screentip;

                case ControlProperties.Supertip:
                    return controlProperty.Supertip;

                default:
                    return "";
            }
        }
    }
}