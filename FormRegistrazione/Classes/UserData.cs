using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormRegistrazione.Classe {
    class UserData {


        private string _nome;

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }


        private string _cognome;

        public string Cognome {
            get { return _cognome; }
            set { _cognome = value; }
        }

        private string _telefono;

        public string Telefono {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _email;

        public string Email {
            get { return _email; }
            set { _email = value; }
        }

        private string _via;

        public string Via {
            get { return _via; }
            set { _via = value; }
        }

        private string _civico;

        public string Civico {
            get { return _civico; }
            set { _civico = value; }
        }


        private string _cap;

        public string Cap {
            get { return _cap; }
            set { _cap = value; }
        }

        private string _citta;

        public string Citta {
            get { return _citta; }
            set { _citta = value; }
        }

        private string _provincia;

        public string Provincia {
            get { return _provincia; }
            set { _provincia = value; }
        }

        private string _URL;

        public string URL {
            get { return _URL; }
            set { _URL = value; }
        }

        public UserData(string nome, string cognome, string telefono, string email, string via, string civico, string cap, string citta, string provincia, string URL) {
            _nome = nome;
            _cognome = cognome;
            _telefono = telefono;
            _email = email;
            _via = via;
            _civico = civico;
            _cap = cap;
            _citta = citta;
            _provincia = provincia;
            _URL = URL;
        }
    }
}
