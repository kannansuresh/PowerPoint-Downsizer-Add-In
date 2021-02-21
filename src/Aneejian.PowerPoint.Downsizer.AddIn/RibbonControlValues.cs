using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal class RibbonControlValues
    {
        private static readonly Properties.Settings settings = Properties.Settings.Default;

        private readonly RibbonControlProperties Potential = new RibbonControlProperties
        (
            label: "Get Downsize Potential",
            description: "Gets the number of unused/deletable layouts and master slides in the current presentation.",
            image: "FileViewDigitalSignatures"
        );

        private readonly RibbonControlProperties Downsize = new RibbonControlProperties
        (
            label: "Downsize",
            description: "Shows the number of unused layouts and master slides in the current presentation, and deletes them after user confirmation.",
            image: new Bitmap(Properties.Resources.downsizerButton)
        );

        private readonly RibbonControlProperties HideTab = new RibbonControlProperties
        (
            label: "Hide Tab",
            description: "Hides the downsizer tab from PowerPoint ribbon. You can access all downsizer functionalities from View tab or Slide Master tab.",
            image: "WindowHide"
        );

        private readonly RibbonControlProperties RevealTab = new RibbonControlProperties
        (
            label: "Reveal Tab",
            description: "Reveal downsizer tab.",
            image: "WindowUnhide"
        );

        private readonly RibbonControlProperties Help = new RibbonControlProperties
        (
            label: "Help",
            description: "Get help and support on Downsizer Add-In.",
            image: "FunctionsLogicalInsertGallery"
        );

        private readonly RibbonControlProperties Update = new RibbonControlProperties
        (
            label: "Update Available",
            description: "A new version of the add-in is available. Click to download.",
            image: "ShapeDownArrow"
        );

        private readonly RibbonControlProperties About = new RibbonControlProperties
        (
            label: "About",
            description: "About Downsizer Add-In.",
            image: "Info"
        );

        private readonly RibbonControlProperties Coffee = new RibbonControlProperties
        (
            label: "Buy a Coffee!",
            description: $"You have used this add-in {settings.App_UsageCounter} times. {Environment.NewLine}Do you like the Downsizer Add-In? Consider buying a coffee for the developer!",
            image: "Heart"
        );

        private readonly RibbonControlProperties HideCoffee = new RibbonControlProperties
        (
            label: "Hide Buy a Coffee button",
            description: "Already donated? Click to hide.",
            supertip: string.Format("You have used this add-in {2} times.{0}Consider buying a coffee if you liked it.{0}{0}Already bought a coffee or annoyed by this button? Click to hide it from everywhere. {0}{0}If you haven't donated, 'Buy a Coffee!' button will reveal itself after you have used this add-in {1} more times.", Environment.NewLine, settings.Coffee_ButtonRevealThreshold * (settings.Coffee_HideCounter + 1), settings.App_UsageCounter),
            image: "WindowMinimize"
        );

        private Dictionary<string, RibbonControlProperties> ControlDictionary => GetControlDictionary();

        private Dictionary<string, RibbonControlProperties> GetControlDictionary()
        {
            var controlDictionary = new Dictionary<string, RibbonControlProperties>()
            {
                ["Potential"] = Potential,
                ["Downsize"] = Downsize,
                ["HideTab"] = HideTab,
                ["RevealTab"] = RevealTab,
                ["Help"] = Help,
                ["About"] = About,
                ["Coffee"] = Coffee,
                ["HideCoffee"] = HideCoffee,
                ["Update"] = Update
            };
            return controlDictionary;
        }

        internal object GetControlProperty(string tag, ControlProperties property)
        {
            if (tag == "Hide")
            {
                tag = Properties.Settings.Default.Ribbon_ShowDownsizerTab ? "HideTab" : "RevealTab";
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