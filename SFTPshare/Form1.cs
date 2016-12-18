using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamir.SharpSsh.jsch;
using Tamir.SharpSsh;
using System.Collections;

namespace SFTPshare
{
    public partial class Form1 : Form
    {
        private string privateKeyPath = @"C://Users//PAPANII//Documents//DistributedSystemsNotes//SuseLinux12AwsKeyPair.pem";
        private String[] files;
        private String[] filesRecap;
        private Sftp sftp;
        private List<string> list;
        private string file;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            // Get a UserInfo object
            UserInfo ui = new UInfo(SFTPConnectSample.Properties.Settings.Default.Password); ;
            // Pass user info to session
            session.setUserInfo(ui);
            // Open the session
            session.connect();
            Channel channel = session.openChannel("sftp");
            ChannelSftp cSftp = (ChannelSftp)channel;
            cSftp.connect();
            */
            try
            {
                sftp = new Sftp(SFTPshare.Properties.Settings.Default.HostName, SFTPshare.Properties.Settings.Default.UserName, SFTPshare.Properties.Settings.Default.Password);
            }
            catch (Exception) { MessageBox.Show("Error instantiating sftp"); }
            try { 
                sftp.AddIdentityFile(privateKeyPath);
            }
            catch (Exception) { MessageBox.Show("Error connecting with private key"); }
            try { 

            sftp.Connect();
            }
            catch (Exception) { }

            //ArrayList res = sftp.GetFileList(".");

            

            
            
            
            
            //ArrayList Newres = sftp.GetFileList(".");
            //filesRecap = sftp.GetFileList(".");
            
        }

        private void browseBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Title = "Upload file";
            opfd.InitialDirectory = @"C:\Users\PAPANII\Documents\DistributedSystemsNotes\filesToPut\";
            opfd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            if(opfd.ShowDialog() == DialogResult.OK)
            {
                file = opfd.FileName;
                fileName = opfd.SafeFileName;
                //MessageBox.Show(fileName);
                try
                {
                    browseTextBox.Text = file;
                }
                catch (Exception){ }
            }
        }

        private void uploadBut_Click(object sender, EventArgs e)
        {
            //upload a file
            try {
                sftp.Put(file, fileName);
                MessageBox.Show("File uploaded successfully");
            }
            catch (Exception) { MessageBox.Show("Error putting data to server"); }
            
            
        }

        private void retrieveBut_Click(object sender, EventArgs e)
        {
            try {
                files = (sftp.GetFileList("."));
                //List<string> list = new List<string>(files);
                list = files.ToList();
                retrieveListBox.DataSource = list;
            MessageBox.Show("File list retieved successfully");
            }
            catch (Exception) { MessageBox.Show("Error retrieving data list from server"); }
        }

        private void downloadBut_Click(object sender, EventArgs e)
        {
            //download a file
            try{
            sftp.Get("a.xml", @"C://Users//PAPANII//Documents//DistributedSystemsNotes//filesToGet//hello.txt");
            MessageBox.Show("File downloaded successfully");
            }
            catch (Exception) { MessageBox.Show("Error getting data to server"); }
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            try
            {
                sftp.Close();
                this.Close();
            }
            catch (Exception) { MessageBox.Show("Error exittingout of FTP Server"); }
        }
    }
}
