using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TemplateEngine
{
    class Templarse
    {
        // PROPERTIES
        private string _template = "";
        public string Template
        {
            get { return _template; }
        }

        private List<StackItem> _stack;
        public List<StackItem> Stack
        {
            get { return _stack; }
        }

        private Hashtable _commands;
        public Hashtable Commands
        {
            get { return _commands; }
        }

        // PUBLIC
        public string ExecuteTemplate()
        {
            string retval = "";
            foreach (StackItem i in _stack)
            {
                if (i.Type.Equals(StackItem.ItemType.HTML))
                {
                    retval += i.Item;
                }
                else if (i.Type.Equals(StackItem.ItemType.COMMAND))
                {
                    retval += Commands(i.Item);
                }
            }
            return retval;
        }

        public string Commands(string c)
        {
            string[] parts = c.Split(' ');
            string cmd = parts[0].ToLower();

            // If the first command isn't a command return blank
            if (_commands.Contains(cmd) == false) { return ""; }

            // Copies the command table except for the current command
            Hashtable temp_cmds = new Hashtable();
            foreach (string k in _commands.Keys)
            {
                if (k != cmd) { temp_cmds[k] = _commands[k]; }
            }

            Templarse temp_tp = new Templarse(this.Commands(cmd), temp_cmds);
            temp_cmds = null;

            // Return
            return temp_tp.ExecuteTemplate();
        }

        // PRIVATE
        private List<StackItem> ParseTemplate(string html)
        {
            List<StackItem> retval = new List<StackItem>();
            
            return retval;
        }

        // CONSTRUCTOR
        public Templarse(string html, Hashtable cmds)
        {
            _template = html;
            _stack = ParseTemplate(html);
            _commands = cmds;
        }
    }
}
