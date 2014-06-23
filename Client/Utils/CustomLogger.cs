using System;
using System.IO;
using System.Xml;
using log4net.Core;
using log4net.Layout;

namespace Client.Utils
{
    public class CustomLoggerFileAppender : log4net.Appender.RollingFileAppender
    {
        protected override void OpenFile(string fileName, bool append)
        {
            string baseDirectory = Path.GetDirectoryName(fileName);
            string fileNameOnly = Path.GetFileName(fileName);
            if (baseDirectory == null) return;
            string newFileName = Path.Combine(baseDirectory, string.Concat(fileNameOnly, "_", DateTime.Now.ToString("yyyyMMdd"), ".xml"));
            base.OpenFile(newFileName, append);
        }

    }

    public class LogXmlLayout : XmlLayoutBase
    {
        protected override void FormatXml(XmlWriter writer, LoggingEvent loggingEvent)
        {
            // Comprobamos que no sea null
            if (loggingEvent == null) throw new ArgumentNullException("loggingEvent");

            writer.WriteStartElement("log");

            writer.WriteStartElement("logTime");
            writer.WriteString(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            writer.WriteEndElement();

            writer.WriteStartElement("logThread");
            writer.WriteString(loggingEvent.ThreadName);
            writer.WriteEndElement();

            writer.WriteStartElement("logLine");
            writer.WriteString(loggingEvent.LocationInformation.LineNumber);
            writer.WriteEndElement();

            writer.WriteStartElement("logMethod");
            writer.WriteString(loggingEvent.LocationInformation.MethodName);
            writer.WriteEndElement();

            writer.WriteStartElement("logLogger");
            writer.WriteString(loggingEvent.LoggerName);
            writer.WriteEndElement();

            writer.WriteStartElement("logLevel");
            writer.WriteString(loggingEvent.Level.DisplayName);
            writer.WriteEndElement();

            writer.WriteStartElement("logUsername");
            writer.WriteString(loggingEvent.Identity);
            writer.WriteEndElement();

            writer.WriteStartElement("logMachine");
            writer.WriteString(loggingEvent.UserName);
            writer.WriteEndElement();

            writer.WriteStartElement("logMessage");
            writer.WriteString(loggingEvent.RenderedMessage);
            writer.WriteEndElement();

            if (loggingEvent.ExceptionObject != null)
            {
                writer.WriteStartElement("logException");

                writer.WriteStartElement("source");
                writer.WriteString(loggingEvent.ExceptionObject.Source);
                writer.WriteEndElement();

                writer.WriteStartElement("message");
                writer.WriteString(GetFullMessage(loggingEvent.ExceptionObject, ""));
                writer.WriteEndElement();

                writer.WriteStartElement("stackTrace");
                writer.WriteString(loggingEvent.ExceptionObject.StackTrace);
                writer.WriteEndElement();

                writer.WriteStartElement("helpLink");
                writer.WriteString(loggingEvent.ExceptionObject.HelpLink);
                writer.WriteEndElement();

                writer.WriteStartElement("dataValues");
                writer.WriteString(string.Join(", ", loggingEvent.ExceptionObject.Data.Values));
                writer.WriteEndElement();

                writer.WriteStartElement("methodException");
                if (loggingEvent.ExceptionObject.TargetSite != null)
                    writer.WriteString(loggingEvent.ExceptionObject.TargetSite.Name);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        /// <summary>
        /// Funcion recursiva que va obteniendo los mensajes de los inner exception
        /// </summary>
        /// <param name="ex">Excepcion</param>
        /// <param name="fullMessage">Mensaje hasta ahora</param>
        /// <returns></returns>
        private string GetFullMessage(Exception ex, string fullMessage)
        {
            if (ex != null)
            {
                fullMessage = string.Concat(fullMessage, "\n", ex.Message);
                return GetFullMessage(ex.InnerException, fullMessage);
            }
            else
            {
                return fullMessage;
            }
        }

    }
}
