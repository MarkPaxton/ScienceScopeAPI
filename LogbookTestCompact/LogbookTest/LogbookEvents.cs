using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mcp;
using mcp.Logs;
using ScienceScope;

namespace LogbookTest
{
    public partial class CompactLogbookTest : Form
    {
        void logbook_Disconnected(object sender, EventArgs e)
        {
            log.Append("logbook_Disconnected", "Logbook Disconnected");
            if (disconnectLogbook)
            {
                logbook = null;
            }
        }

        void logbook_CommandQueueFull(object sender, CommandQueueFullEventArgs e)
        {
            log.Append("logbook_CommandQueueFull", "Logbook Command Queue Full");
        }

        void logbook_CommandTimeout(object sender, CommandTimeoutEventArgs e)
        {
            log.Append("logbook_CommandTimeout", "Logbook Command Timeout");
            UpdateTextBoxInvoke(textBox1, String.Format("{0}", e.FailedCommand.name), logLines);
        }

        void logbook_CommandFailed(object sender, CommandFailedEventArgs e)
        {
            log.Append("logbook_CommandFailed", "Logbook Command Failed");
            UpdateTextBoxInvoke(textBox1, String.Format("{0}", e.FailedCommand.name), logLines);
        }

        void logbook_CommandResult(object sender, CommandResultEventArgs e)
        {
            log.Append("logbook_CommandResult", "Logbook Command Result");
            UpdateTextBoxInvoke(textBox1, String.Format("{0}: {1}", e.Command.name, e.Result), logLines);
        }
    }
}