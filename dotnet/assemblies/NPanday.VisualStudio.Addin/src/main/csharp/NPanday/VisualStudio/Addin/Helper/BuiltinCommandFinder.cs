using System;
using System.Collections.Generic;
using System.Text;
using EnvDTE80;
using Microsoft.VisualStudio.CommandBars;
using NPanday.Logging;

namespace NPanday.VisualStudio.Addin.Helper
{
    public class BuiltinCommandFinder
    {
        private readonly DTE2 _application;
        private readonly Logger _logger;

        public BuiltinCommandFinder(DTE2 application, Logger logger)
        {
            _application = application;
            _logger = logger;
        }

        public bool FindCommands(string barAndCaption, out CommandBarControl[] controls)
        {
            List<CommandBarControl> controlList = new List<CommandBarControl>();

            string barName = null;
            string caption = null;
            if (barAndCaption.Contains("->"))
            {
                string[] both = barAndCaption.Split(new string[] { "->" }, 2, StringSplitOptions.None);
                barName = both[0];
                caption = both[1];
            }
            else
                caption = barAndCaption;

            CommandBars bars = ((CommandBars)_application.CommandBars);

            if (barName != null)
            {
                CommandBar bar = bars[barName];
                if (bar == null)
                {
                    _logger.Log(Level.DEBUG, "Could not find a command bar named '" + barName + "'.");
                }
                else
                {
                    CommandBarControl[] found;
                    if (FindCommands(bar, caption, out found))
                    {
                        controlList.AddRange(found);
                    }
                }
            }

            foreach (CommandBar bar in bars)
            {
                CommandBarControl[] found;
                if (FindCommands(bar, caption, out found))
                {
                    controlList.AddRange(found);
                }
            }
            controls = controlList.ToArray();

            if (controlList.Count == 0)
            {
                _logger.Log(Level.DEBUG, "Could not find any of commands: '" + barAndCaption + "'.");
                return false;
            }

            return true;
        }

        public bool FindCommands(CommandBar commandBar, string commandCaption, out CommandBarControl[] controls)
        {
            List<CommandBarControl> controlList = new List<CommandBarControl>();

            foreach (CommandBarControl control in commandBar.Controls)
            {
                if (IsCommand(control, commandCaption))
                {
                    controlList.Add(control);
                }
            }

            controls = controlList.ToArray();

            return controlList.Count > 0;
        }

        public void PrintAllAvailableCommands()
        {
            foreach (CommandBar commandBar in (CommandBars)_application.CommandBars)
            {
                foreach (CommandBarControl control in commandBar.Controls)
                {
                    try
                    {
                        _logger.Log(Level.DEBUG, commandBar.Name + "->" + control.Caption);
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
        }

        public bool IsCommand(CommandBarControl control, string commandCaption)
        {
            CommandBar bar = control.Parent;
            string caption = control.Caption;

            if (string.IsNullOrEmpty(caption))
                return false;

            if (control.Caption == commandCaption)
                return true;

            if (caption.Replace("&", "") == commandCaption)
                return true;

            try
            {
                string barName = bar.Name; // fails sometimes

                if ((barName + "->" + caption) == commandCaption)
                    return true;

                if ((barName + "->" + caption.Replace("&", "")) == commandCaption)
                    return true;
            }
            catch
            {
            }

            return false;
        }
    }
}
