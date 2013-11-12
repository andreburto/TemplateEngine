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

        }

        public void RemoveVariable(string key)
        {
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
        }
    }
}
