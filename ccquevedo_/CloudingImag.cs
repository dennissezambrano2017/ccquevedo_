using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;


namespace ccquevedo_
{
    public partial class CloudingImag : Form
    {
        public static Cloudinary cloud;
        private string urlImage;
        Account accoun = new Account(
            "camara-de-comercio-de-quevedo",
            "786557385641997",
            "ZBHl1dtyxaDnRaYQUm61XMaLgMQ");

        public string UrlImage { get => urlImage; set => urlImage = value; }

        public CloudingImag()
        {
            InitializeComponent();
            cloud = new Cloudinary(accoun);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void cargarImagen(string ruta)
        {
            try
            {
                //var uploadParams = new ImageUploadParams()
                //{
                //    File = new FileDescription(ruta),
                //};
                //var uploadResult = cloud.Upload(uploadParams);

                //ruta = uploadResult.SecureUri.ToString();
                ruta = "https://res.cloudinary.com/camara-de-comercio-de-quevedo/image/upload/v1652834621/p2arazqsoayi2rvwpspy.png";
                Nuevo frmn= Nuevo.FormCrear();
                frmn.EditaText(ruta);
                MessageBox.Show("Foto subida correctamente al servidor");


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult resul = op.ShowDialog();
            if (resul == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                textBox1.Text = op.FileName;
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                cargarImagen(textBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("Necesita elegir una iamgen antes para poder caragrla al servidor", "Información");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
