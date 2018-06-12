using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Filetext_ChangerForm
{
    public partial class MassFileChanger : Form
    {
        public MassFileChanger()
        {
            InitializeComponent();
        }
        //Deklarierung lokaler Variablen
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        FolderBrowserDialog fbd2 = new FolderBrowserDialog();
        DialogResult result, result2;
        string[] files;
        string sePath = "";
        string saPath = "";


        private void getPath()
        {
            // FolderBrowserDialog
            result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                sePath = fbd.SelectedPath;
                files = Directory.GetFiles(sePath);
                tb_selectPath.Text = sePath;
                lb_AmountFiles.Text = files.Length.ToString() + " ausgewählte Dateien";
            }
            else
            {
                MessageBox.Show("Sie haben keine Datei ausgewählt!");
            }
        }

        private void setPath()
        {
            // FolderBrowserDialog2
            result2 = fbd2.ShowDialog();
            if (result2 == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                saPath = fbd2.SelectedPath;
                tb_savePath.Text = saPath;
            }
            else
            {
                MessageBox.Show("Sie haben keine Datei ausgewählt!");
            }
        }


        public void btn_ofd_Click(object sender, EventArgs e)
        {
            getPath();
        }

        private void btn_sfd_Click(object sender, EventArgs e)
        {
            setPath();
        }

        private void cb_Overwrite_CheckedChanged(object sender, EventArgs e)
        {
            // ausblendung der Zielangabe wenn Datei überschrieben werden soll
            if (cb_Overwrite.Checked == false)
            {
                btn_sfd.Visible = true;
                tb_savePath.Visible = true;
            }
            else
            {
                btn_sfd.Visible = false;
                tb_savePath.Visible = false;
            }
        }

        private void success()
        {
            MessageBox.Show("Dateien wurden erfolgreich abgeändert!");
        }

        private void overWrite()
        {
            try
            {
                foreach (string file in files)
                {
                    // Variabel mit Name und Dateiendung
                    string fileName = Path.GetFileName(file);
                    string newFileName = fileName.Replace(tb_enteredString.Text, tb_changeToString.Text);
                    string oldFilePath = Path.Combine(sePath, newFileName);
                    File.Copy(file, oldFilePath);
                    File.Delete(file);
                    /* Manipulation der Datei durch eingegebene änderung in tb_changeToString
                    'Überschreiben' beziehungsweise die alten Dateiverzeichnisse
                    in einer Variabel speichern, eine anders genannte Kopie
                    der alten Dateien machen und danach löschen */
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dateien wurden nicht gefunden");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Dateien konnten nicht geladen ");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Es müssen zwei Ordner Oben angegeben sein");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            success();
        }


        private void preview()
        {
            MessageBox.Show("Sollen die Dateien nach diesem Schema geändert werden?\n" + files[0]
                + " zu " + files[0].Replace(tb_enteredString.Text, tb_changeToString.Text), "Bestätigung", MessageBoxButtons.YesNo);


        }

        private void copy()
        {
            try
            {
                // In anderen Ordner
                foreach (string file in files)
                {
                    // Variabel mit Name und Dateiendung
                    string fileName = Path.GetFileName(file);
                    string newFileName = fileName.Replace(tb_enteredString.Text, tb_changeToString.Text);
                    string newFilePath = Path.Combine(saPath, newFileName);
                    File.Copy(file, newFilePath);
                    /* Manipulation der Datei durch eingegebene änderung in tb_changeToString
                    Neues Verzeichnis aus tb_savePath herauslesen und danach dorthin kopieren*/
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dateien wurden nicht gefunden");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Dateien konnten nicht geladen ");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Es müssen zwei Ordner Oben angegeben sein");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            success();

        }

        private void checkIfSelected()
        {
            try
            {
                files = Directory.GetFiles(sePath);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Es fehlen Ordnerangaben");
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (cb_Overwrite.Checked == true)
            {
                checkIfSelected();
                var result = MessageBox.Show("Sollen die Dateien nach diesem Schema geändert werden?\n" + files[0]
                + " zu " + files[0].Replace(tb_enteredString.Text, tb_changeToString.Text), "Bestätigung", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    overWrite();
                }
            }

            else
            {
                checkIfSelected();
                var result = MessageBox.Show("Sollen die Dateien nach diesem Schema geändert werden?\n" + files[0]
                + "\nzu\n" + Path.Combine(saPath, Path.GetFileName(files[0]).Replace(tb_enteredString.Text, tb_changeToString.Text)), "Bestätigung", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    copy();
                }
            }
        }
    }
}

















