using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Managment_System.Model
{
    public class Organization
    {

        public String cin
        {
            get;
            set;
        }

        public String nom
        {
            get;
            set;
        }

        public String adresse
        {
            get;
            set;
        }

        public String mail
        {
            get;
            set;
        }

        public String telephone
        {
            get;
            set;
        }

        public Organization(String cin, String nom , String adresse , String mail , String telephone)
        {
            this.cin = cin;
            this.nom = nom;
            this.adresse = adresse;
            this.mail = mail;
            this.telephone = telephone;
        }
    }
}
