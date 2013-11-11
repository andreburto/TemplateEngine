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

            // code goes here

            return retval;
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
            

        }
    }
}
