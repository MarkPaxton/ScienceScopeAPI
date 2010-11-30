using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScienceScope;
using Logs;
using SensorShare;
using System.Threading;

namespace LogbookTest
{
    public partial class DesktopLogbookTest : Form
    {
        protected Logbook logbook = null;
        protected const string logbookPort = "COM5";

        protected const int logLines = 100;

        protected Log log = new Log();

        TextBoxDelegate textBoxDelegate = null;
        LogMessageEventHandler displayMessage = null;

        public DesktopLogbookTest()
        {
            InitializeComponent();
            textBoxDelegate = new TextBoxDelegate(TextHelper.UpdateTextBox);
            displayMessage = new LogMessageEventHandler(UpdateLogText);

        }

        private void DesktopLogbookTest_Load(object sender, EventArgs e)
        {
            displayMessage = new LogMessageEventHandler(displayMessage);
            log.OnLogMessage += displayMessage;
            log.Start();

            log.Append("DesktopLogbookTest_Load", String.Format("{0} {1}", "Starting on", System.Net.Dns.GetHostName()));
        }

        public void UpdateTextBoxInvoke(TextBox box, string displayText, int linesToshow)
        {
            Object[] args = new object[3];
            args[0] = box;
            args[1] = displayText;
            args[2] = linesToshow;
            box.BeginInvoke(textBoxDelegate, args);
        }

        public void UpdateLogText(object sender, LogMessageEventArgs args)
        {
            UpdateTextBoxInvoke(textBox1, args.Message, logLines);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (logbook == null)
            {
                disconnectLogbook = false;
                logbook = new Logbook(logbookPort);

                logbook.CommandResult += new CommandResultEventHandler(logbook_CommandResult);
                logbook.CommandFailed += new CommandFailedEventHandler(logbook_CommandFailed);
                logbook.CommandTimeout += new CommandTimeoutEventHandler(logbook_CommandTimeout);
                logbook.CommandQueueFull += new CommandQueueFullEventHandler(logbook_CommandQueueFull);
                logbook.Disconnected += new EventHandler(logbook_Disconnected);

                log.Append("connectButton_Click", String.Format("Connecting Logbook on {0}", logbookPort));
                try
                {
                    logbook.Activate();
                }
                catch (LogbookConnectionException ex)
                {
                    log.LogException(ex);
                }
            }
            else
            {
                if (!logbook.IsActive)
                {
                    log.Append("connectButton_Click", String.Format("Reactivating Logbook on {0}", logbookPort));
                    logbook.Activate();
                }
            }
        }

        private bool disconnectLogbook = false;
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (logbook != null)
            {
                log.Append("disconnectButton_Click", String.Format("Disconnecting Logbook on {0}", logbookPort));
                logbook.Deactivate();
            }
        }

        private void getVersionButton_Click(object sender, EventArgs e)
        {
            if (logbook != null)
            {
                if (logbook.IsActive)
                {
                    log.Append("getVersionButton_Click", String.Format("Sending {0}", Logbook.Command.GetVersion.name));
                    logbook.sendCommand(Logbook.Command.GetVersion);
                }
            }
        }

        private void takeReadingButton_Click(object sender, EventArgs e)
        {
            if (logbook != null)
            {
                if (logbook.IsActive)
                {
                    log.Append("takeReadingButton_Click", String.Format("Sending {0}", Logbook.Command.ReadASCII.name));
                    logbook.sendCommand(Logbook.Command.ReadASCII);
                }
            }
        }

        private void DesktopLogbookTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logbook != null)
            {
                if (logbook.IsActive)
                {
                    log.Append("DesktopLogbookTest_FormClosing", "Deactivating Logbook");
                    logbook.Deactivate();
                    logbook = null;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logbook.IsActive)
            {
                log.Append("identifyLogbookSensors", "Identifying sensors");
                log.Append("identifyLogbookSensors", "Input power on & confirm extended mode");
                logbook.sendCommand(Logbook.Command.InputPowerOn);
                Thread.Sleep(100);
                logbook.sendCommand(Logbook.Command.ConfirmExtendedProtocol);
                Thread.Sleep(100);
                log.Append("identifyLogbookSensors", "Getting sensor ranges");
                logbook.sendCommand(Logbook.Command.GetSensorRanges);
            }
        }
    }
}