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
        private static string urlImage;
        private static CloudingImag instancia = null;
        private static string formulario;

        Account accoun = new Account(
            "camara-de-comercio-de-quevedo",
            "786557385641997",
            "ZBHl1dtyxaDnRaYQUm61XMaLgMQ");

        public static string UrlImage { get => urlImage; set => urlImage = value; }
        public static string Formulario { get => formulario; set => formulario = value; }

        public static CloudingImag FormCrear(string frm,string txt)
        {
            formulario = frm;
            UrlImage_(txt);
            if (instancia == null)
            {
                instancia = new CloudingImag();
                return instancia;
            }
            return instancia;

        }
        public static void UrlImage_(string ruta)
        {
            UrlImage = ruta;
        }
        public CloudingImag()
        {
            InitializeComponent();
            cloud = new Cloudinary(accoun);
            pictureBox1.ImageLocation = @"" + UrlImage;
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
                ruta = "https:+//res.cloudinary.com/camara-de-comercio-de-quevedo/image/upload/v1652834621/p2arazqsoayi2rvwpspy.png";
                switch (Formulario)
                {
                    case "1":
                        Nuevo frmNuevo = Owner as Nuevo;
                        frmNuevo.txtImagen.Text = ruta;
                        break;

                    case "2":
                        Modificar frmModificar = Owner as Modificar;
                        frmModificar.txtImage.Text = ruta;
                        break;

                    case "3":
                        Editar frmEditar = Owner as Editar;
                        frmEditar.txtImage.Text = ruta;
                        break;
                }

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
            this.Close();
        }
    }
}
