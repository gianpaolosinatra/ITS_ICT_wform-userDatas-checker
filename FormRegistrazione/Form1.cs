using FormRegistrazione.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegistrazione {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();




        /*
         * Realizzare un form di registrazione utente
         * 
         * Attraverso i seguenti campi:
         * Nome - Cognome - Numero di telefono - email - Indirizzo (via + n° civico) - CAP Citta + Provincio
         * 
         * --------------------------------------------------------------------------------------------------
         * 
         * Controllare che il nome il nome e il cognome non contengano numeri
         * 
         * Controllare che il numero di telefono sia esclusivamente numerico
         * (oppure avere il prefisso internazionale  "+XX" e/o il "/" dopo i primi 3 numeri)
         * 
         * controllare che l'email sia in formato valido (prima parte una stringa alfanumerica + "." + @ + ".alfanumerico")
         * 
         * Via -> deve essere coposta solo da lettere 
         * il numero civico deve avere solo numeri + (/ oppure "bis", "tris", "quater")
         * 
         * CAP deve essere esclusivamente numerico
         * 
         * Città e provincia sono esclusivamente composte da lettere
         * 
         */





        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void txtNome_TextChanged(object sender, EventArgs e) {

        }

        bool IsValidEmail(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            } catch {
                return false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            UserData user = new UserData(
                 txtNome.Text,
                 txtCognome.Text,
                 txtTelefono.Text,
                 txtEmail.Text,
                 txtVia.Text,
                 txtCivico.Text,
                 txtCap.Text,
                 txtCitta.Text,
                 txtProvincia.Text.ToUpper(),
                 txtSito.Text);
            CheckDatas(user);

        }
        void CheckDatas(UserData user) {
            int errNum = 0;
            string errors = "";
            if (!CheckNomeCognome(user.Nome)) { 
                errNum++;
                errors += errNum.ToString() +". Nome errato, inserire correttamente il nome \n";
            }
            if (!CheckNomeCognome(user.Cognome)) { 
                errNum++;
                errors += errNum.ToString() + ". Cognome errato, inserire correttamente il nome \n";
            }
            if (!CheckTelefono(user.Telefono)) { 
                errNum++;
                errors += errNum.ToString() + ". Telefono errato, inserire correttamente il numero di cellulare \n";
            }
            if (!CheckEmail(user.Email)) {
                errNum++;
                errors += errNum.ToString() + ". Email errata, inserire email corretta \n";
            }
            if (!CheckVia(user.Via)) { 
                errNum++;
                errors += errNum.ToString() + ". Via errata, inserire Via corretta \n";
            }
            if (!CheckCivico(user.Civico)) { 
                errNum++;
                errors += errNum.ToString() + ". Numero civico errato, reinserire n. civico\n";
            }
            if (!CheckCAP(user.Cap)) { 
                errNum++;
                errors += errNum.ToString() + ". Codice di avviamento postale errato, reinserire C.A.P.\n";
            }
            if (!CheckCitta(user.Citta)) {
                errNum++;
                errors += errNum.ToString() + ". Città errata, reinserire Città\n";
            }
            if (!CheckProvincia(user.Provincia)) {
                errNum++;
                errors += errNum.ToString() + ". Provincia errata, reinserire Provincia\n";
            }
            if (!CheckURL(user.URL)) {
                errNum++;
                errors += errNum.ToString() + ". URL errato, reinserire URL o URI\n";
            }

            if (errNum > 0)
                MessageBox.Show("ERRORI RISCONTRATI\n"+errors);
            else
                MessageBox.Show("Dati inseriti correttamente");
        }
        
        bool CheckNomeCognome(string nome) {
            var uNome = txtNome.Text;
            string ptnNome = @"^[a-zA-Z]+$";
            Regex rNome = new Regex(ptnNome);
            return rNome.IsMatch(nome);
        }

        bool CheckTelefono(string telefono) {
            var uTelefono = txtTelefono.Text;
            string ptnTelefono = @"^(\+\d{2,3})?[ ]?\d{9,11}$";
            Regex rTelefono = new Regex(ptnTelefono);
            return rTelefono.IsMatch(telefono);
        }

        bool CheckEmail(string email) {
            var uEmail = txtEmail.Text;
            string ptnEmail = @"^([\w\.\-]+)@([\w\-\.]+)((\.(\w){1,3})+)$";
            Regex rEmail = new Regex(ptnEmail);
            return rEmail.IsMatch(email);
        }

        bool CheckVia(string via) {
            var uVia = txtEmail.Text;
            string ptnVia = @"^[\w\.\,\-\&\'ìùèéòùà\(\)\<\> ]+$";
            Regex rVia = new Regex(ptnVia);
            return rVia.IsMatch(via);
        }

        bool CheckCivico(string civico) {
            var uCivico = txtCivico.Text;
            string ptnCivico = @"^[\d]{1,3}(\/[\d]{1,2})?( bis| tris| quater)?$";
               Regex rCivico = new Regex(ptnCivico);
            return rCivico.IsMatch(civico);
        }

        bool CheckCAP(string CAP) {
            var uCAP = txtCap.Text;
            string ptnCAP = @"^[\d]{5}$";
            Regex rCAP = new Regex(ptnCAP);
            return rCAP.IsMatch(CAP);
        }

        bool CheckCitta(string citta) {
            var uCitta = txtNome.Text;
            string ptnCitta = @"^[a-zA-Z]+$";
            Regex rCitta = new Regex(ptnCitta);
            return rCitta.IsMatch(citta);
        }

        bool CheckProvincia(string provincia) {
            var uProvincia = txtProvincia.Text;
            string ptnProvincia = @"^[a-zA-Z]{2}$";
            Regex rProvincia = new Regex(ptnProvincia);
            return rProvincia.IsMatch(provincia);
        }

        bool CheckURL(string URL) {
            var uURL = txtSito.Text;
            string ptnURL = @"^(https\:\/\/|http\:\/\/)?www\.[\w\-\.\?\%\&\=]+\.\w+$";
            Regex rURL = new Regex(ptnURL);
            return rURL.IsMatch(URL);
        }

    }
}
