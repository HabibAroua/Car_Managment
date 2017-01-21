using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Managment_System.Model
{
    public class Voiture
    {
        public String reference
        {
            get;
            set;
        }
        public String marque
        {
            get;
            set;
        }
        public String carburant
        {
            get;
            set;
        }
        public int prixParJour
        {
            set;
            get;
        }
        public int prixTotal
        {
            set;
            get;
        }

        public Voiture()
        { }

        public Voiture(String reference, String marque, String carburant, int prixParJour, int prixTotal)
        {
            this.reference = reference;
            this.marque = marque;
            this.carburant = carburant;
            this.prixParJour = prixParJour;
            this.prixTotal = prixTotal;
        }
    }
}
