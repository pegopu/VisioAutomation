﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;

namespace VisioPowerTools2010
{
    public partial class ThisAddIn
    {
        public VisioAutomation.Scripting.Session ScriptingSession;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.ScriptingSession = new VisioAutomation.Scripting.Session(Globals.ThisAddIn.Application);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }



        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
