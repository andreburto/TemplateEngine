using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateEngine
{
    class StackItem
    {
        // PROPERTIES
        private string _item;
        public string Item
        {
            get { return _item; }
        }

        private int _type;
        public int Type
        {
            get { return _type; }
        }

        // PUBLIC
        public enum ItemType { HTML = 0, COMMAND = 1 }

        // PRIVATE
        private string cleanCommand(string cmd)
        {
            // Take <% off the front
            cmd = cmd.Substring(2);

            // Take %> off the end
            cmd = cmd.Substring(0, cmd.Length - 2);

            // Trim extra spaces at the beinning or end
            while (cmd.Substring(0, 1) == " ") { cmd = cmd.Substring(1); }
            while (cmd.Substring(cmd.Length - 1, 1) == " ") { cmd = cmd.Substring(0, cmd.Length - 1); }

            // Return the cleaned up command
            return cmd;
        }

        // CONSTRUCTOR
        public StackItem(string item, int type)
        {
            // Clean up a command if it is one
            if (type == (byte)ItemType.COMMAND) { _item = cleanCommand(item); }
            else { _item = item; }
            // Assign type to this property
            _type = type;
        }
    }
}
