using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Managment_System.Model
{
    public class Utilisateur
    {
        public int id
        {
            get;
            
            set;
            
        }
        public String nom
        {
            get;
            
            set;
            
        }
        public String prenom
        {
            get;
            
            set;
            
        }
        public String mail
        {
            get;
            
            set;
            
        }
        public Compte compte
        {
            get;

            set;
           
        }
        
        public Utilisateur(int id,String nom,String prenom,String mail,Compte compte)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.compte = compte;
        } 
           
    }
}
