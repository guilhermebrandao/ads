using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackNight
{
    public partial class GuiServerSocket : Form
    {
        private Socket socket;
        private Thread thread;


        private NetworkStream networkStream;
        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;

        TcpListener tcpListener;

        public GuiServerSocket()
        {
            InitializeComponent();
            thread = new Thread(new ThreadStart(RunServer));
            thread.Start();
        }
        private void AddToListBox(object oo)
        {
            Invoke(new MethodInvoker(
                           delegate { listBoxMensagensRecebidas.Items.Add(oo); }
                           ));
        }


        public void RunServer()
        {

            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2001);
                tcpListener = new TcpListener(ipEndPoint);
                tcpListener.Start();

                AddToListBox("Servidor habilitado e escutando porta..." + "Server App");

                socket = tcpListener.AcceptSocket();
                networkStream = new NetworkStream(socket);
                binaryWriter = new BinaryWriter(networkStream);
                binaryReader = new BinaryReader(networkStream);

                AddToListBox("Conexão recebida!" + "Server App");
                binaryWriter.Write("\nConexão efetuada!");

                string messageReceived = "";
                do
                {
                    messageReceived = binaryReader.ReadString();

                    AddToListBox("Cliente: " + messageReceived);

                } while (socket.Connected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (binaryReader != null)
                {
                    binaryReader.Close();
                }
                if (binaryWriter != null)
                {
                    binaryWriter.Close();
                }
                if (networkStream != null)
                {
                    networkStream.Close();
                }
                if (socket != null)
                {
                    socket.Close();
                }
                MessageBox.Show("conexão finalizada", "Server App");

            }
        }

        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                binaryWriter.Write(textBox1.Text);
            }
            catch (SocketException socketEx)
            {
                MessageBox.Show(socketEx.Message, "Erro");
            }
            catch (Exception socketEx)
            {
                MessageBox.Show(socketEx.Message, "Erro");
            }
        }

        private void ServerApp_FormClosing(object sender, FormClosingEventArgs e)
        {

            tcpListener.Stop();
            Environment.Exit(0);

        }
    }
}