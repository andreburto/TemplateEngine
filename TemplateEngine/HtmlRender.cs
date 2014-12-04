using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateEngine
{
    class HtmlRender
    {
        // PRIVATE VARIABLES
        private Hashtable _variables;
        private Templarse _templarse;

        // PUBLIC
        public void AddVariable(string key, string val)
        {
            if (key.Length == 0 || val.Length == 0) { return; }
            _variables.Add(key, val);
        }

        public void RemoveVariable(string key)
        {
            if (key.Length == 0) { return; }
            if (_variables.Contains(key) == false) { return; }
            _variables.Remove(key);
        }

        public string Render(string template)
        {
            _templarse = new Templarse(template, _variables);
            return _templarse.ExecuteTemplate();
        }

        // PRIVATE
        private string Lz(string n)
        {
            int i = int.Parse(n);
            if (i < 10) { return "0" + n; }
            return n;
        }

        // CONSTRUCTOR
        public HtmlRender() { }

        public HtmlRender(Hashtable pre_var)
        {
            _variables = pre_var;
        }
    }
}
