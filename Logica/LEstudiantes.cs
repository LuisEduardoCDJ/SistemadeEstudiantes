using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        //private Librarys librarys;
        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objectos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //librarys = new Librarys();
            image = (PictureBox)objectos[0];
        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "El campo es requerido";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "El campo es requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "El campo es requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listTextBox[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "El campo es requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();
                        }
                        else
                        {
                            if (textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                            {
                                var imageArray = uploadimage.ImageToByte(image.Image);
                                //using (var db = new Conexion())
                                //{
                                //    db.Insert(new Estudiante()
                                //    {
                                //        nid = listTextBox[0].Text,
                                //        nombre = listTextBox[1].Text,
                                //        apellido = listTextBox[2].Text,
                                //        email = listTextBox[3].Text,
                                //    });
                                //}
                                _Estudiante.Value(e => e.nid, listTextBox[0].Text)
                                    .Value(e => e.nombre, listTextBox[1].Text)
                                    .Value(e => e.apellido, listTextBox[2].Text)
                                    .Value(e => e.email, listTextBox[3].Text)
                                    .Value(e => e.image, imageArray)
                                    .Insert();


                            }
                            else
                            {
                                listLabel[3].Text = "Emai no valido";
                                listLabel[3].ForeColor = Color.Red;
                                listTextBox[3].Focus();
                            }
                        }
                    }
                }
            }
        }
    }
}
