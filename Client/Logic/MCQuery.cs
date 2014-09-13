using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using MSSClient.Resources;
using MSSLogic;
using MSSUtils.Exceptions;
using MSSUtils.Logger;

namespace MSSClient.Logic
{
    public static class MCQuery
    {
        public static QueryResponse Query(string serverHost, int serverPort)
        {
            QueryResponse response = new QueryResponse();

            try
            {
                // Start network control
                NetworkControl control = new NetworkControl(serverHost, serverPort);
                // Start client
                control.SetUdpClient();
                // Send handshake
                int token = control.GetHandShake();
                // Obtain full data
                byte[] data = control.GetFullStats(token);
                // Codificamos
                data = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, data);
                // Mapeamos las respuestas a un modelo
                response = new QueryResponse(data);
            }
            catch (UnknownHostException ex)
            {
                Logger.Warn(Messages.UnknownHost, ex);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SocketException ex)
            {
                Logger.Error(Messages.ServerError, ex);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                Logger.Warn(Messages.ServerDontRespond);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Logger.Fatal(Messages.ServerError, ex);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Devolvemos el modelo al formulario
            return response;
        }
    }
}
