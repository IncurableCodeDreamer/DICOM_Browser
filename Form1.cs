using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DicomBrowser
{
    public partial class Browser : Form
    {
        private ushort portMove;
        private string selectedPatient;
        private string callAET; 
        private string IP;
        private ushort port;
        private string AET;
        private string state;
        private ListViewItem patientsList;
        private ListViewItem imagesList;
        private string selectedImage;
        private Bitmap imageToShow;               

        public Browser()
        {
            InitializeComponent();
            port = 10100;
            IP = "127.0.0.1";
            AET = "KLIENTL";
            portMove = 10104;
            callAET = "ARCHIWUM";
            state = string.Empty;
            patientsList = new ListViewItem();
            imagesList = new ListViewItem();
        }              
        
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            IP = IP_text.Text;
            port = Convert.ToUInt16(PORT_text.Text);
            AET = AET_text.Text;
            callAET = AETSERWERA_txt.Text;
            portMove = Convert.ToUInt16(PORTCLIENT_txt.Text);

            bool stan = gdcm.CompositeNetworkFunctions.CEcho(IP, port, AET, callAET);
            if (stan) {
                StatusText.Visible = true;
                StatusText.Text = "POŁĄCZONO Z SERWEREM";
            }
            else
            {
                StatusText.Visible = true;
                StatusText.Text = "NIE POŁĄCZONO Z SERWEREM";
            }
        }      

        private void GetStudies()
        {
            FilesList.Clear();
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.ePatient;
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();
            if (selectedPatient == null)
            {
                StatusText.Text = "PROSZE WYBRAĆ PACJENTA";
                return;
            }

            gdcm.KeyValuePairType klucz1 = new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), selectedPatient);
            klucze.Add(klucz1);

            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze, true);
            if (!zapytanie.ValidateQuery())
            {
                StatusText.Text = "BŁĘDNE ZAPYTANIE";
                return;
            }
                      
            String odebrane = System.IO.Path.Combine(".", "odebrane");
            if (!System.IO.Directory.Exists(odebrane))
            {
                System.IO.Directory.CreateDirectory(odebrane);
            }
            String dane = System.IO.Path.Combine(odebrane, System.IO.Path.GetRandomFileName());
            System.IO.Directory.CreateDirectory(dane);

            bool stan = gdcm.CompositeNetworkFunctions.CMove(IP, Convert.ToUInt16(PORT_text.Text), zapytanie, portMove, AET, callAET, dane);

            if (!stan)
            {
                StatusText.Text = "BŁĄD";
                return;
            }

            List<string> pliki = new List<string>(System.IO.Directory.EnumerateFiles(dane));
            foreach (String plik in pliki)
            {
                gdcm.PixmapReader reader = new gdcm.PixmapReader();
                reader.SetFileName(plik);
                if (!reader.Read())
                {
                    continue;
                }

                gdcm.Bitmap bmjpeg2000 = pxmap2jpeg2000(reader.GetPixmap());
                Bitmap[] X = gdcmBitmap2Bitmap(bmjpeg2000);
                for (int i = 0; i < X.Length; i++)
                {
                    String name = String.Format("{0}_warstwa{1}.jpg", plik, i);
                    X[i].Save(name);
                    imagesList.Text = name;
                    FilesList.Items.Add(name);
                }              
            }
        }

        private void ShowImage()
        {
            string str = Environment.CurrentDirectory;
            if (selectedImage == null)
            {
                StatusText.Text = "PROSZĘ WYBRAĆ OBRAZ";
                return;
            }
            selectedImage = selectedImage.Remove(0, 1);
            string imagePath = str + selectedImage;
            PictureBox.Image = new Bitmap(imagePath);
        }        
     
        public static Bitmap[] gdcmBitmap2Bitmap(gdcm.Bitmap bmjpeg2000)
        {          
            uint cols = bmjpeg2000.GetDimension(0);
            uint rows = bmjpeg2000.GetDimension(1);
            uint layers = bmjpeg2000.GetDimension(2);
                      
            Bitmap[] ret = new Bitmap[layers];
            byte[] bufor = new byte[bmjpeg2000.GetBufferLength()];
            if (!bmjpeg2000.GetBuffer(bufor))
                throw new Exception("błąd pobrania bufora");

            for (uint l = 0; l < layers; l++)
            {
                Bitmap X = new Bitmap((int)cols, (int)rows);
                double[,] Y = new double[cols, rows];
                double m = 0;

                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                    {
                        int j = ((int)(l * rows * cols) + (int)(r * cols) + (int)c) * 2;
                        Y[r, c] = (double)bufor[j + 1] * 256 + (double)bufor[j];
                        if (Y[r, c] > m)
                            m = Y[r, c];
                    }

                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                    {
                        int f = (int)(255 * (Y[r, c] / m));
                        X.SetPixel(c, r, Color.FromArgb(f, f, f));
                    }
                ret[l] = X;
            }
            return ret;
        }

        public static gdcm.Bitmap pxmap2jpeg2000(gdcm.Pixmap px)
        {
            gdcm.ImageChangeTransferSyntax change = new gdcm.ImageChangeTransferSyntax();
            change.SetForce(false);
            change.SetCompressIconImage(false);
            change.SetTransferSyntax(new gdcm.TransferSyntax(gdcm.TransferSyntax.TSType.JPEG2000Lossless));

            change.SetInput(px);
            if (!change.Change())
                throw new Exception("Nie przekonwertowano typu bitmapy na jpeg2000");

            gdcm.Bitmap outimg = change.GetOutputAsBitmap();

            return outimg;
        }

        private void PatientIdList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedPatient = e.Item.Text;
            GetStudies();
        }

        private void FilesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedImage = e.Item.Text;
            ShowImage();
        }

        private void GetPatientBtn_Click(object sender, EventArgs e)
        {
            PatientIdList.Clear();
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.ePatient;
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();
            gdcm.KeyValuePairType klucz1 = new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0010), "*");
            klucze.Add(klucz1);
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), ""));
            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze);
            if (!zapytanie.ValidateQuery())
            {
                StatusText.Text = "BŁĘDNE ZAPYTANIE";
                return;
            }

            gdcm.DataSetArrayType wynik = new gdcm.DataSetArrayType();
            bool stan = gdcm.CompositeNetworkFunctions.CFind(IP, ushort.Parse(PORT_text.Text), zapytanie, wynik, AET, "ARCHIWUM");

            if (!stan)
            {
                StatusText.Text = "BŁĄD";
                return;
            }

            foreach (gdcm.DataSet x in wynik)
            {
                gdcm.DataElement de = x.GetDataElement(new gdcm.Tag(0x0010, 0x0020)); // konkretnie 10,20 = PATIENT_ID
                gdcm.Value val = de.GetValue();
                string str = val.toString();
                patientsList.Text = str;               
                PatientIdList.Items.Add(str);
            }
        }
    }
}
